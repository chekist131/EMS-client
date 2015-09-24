using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Xml;
using System.Xml.Linq;
using System.Globalization;

namespace EMS_gui
{
    public partial class Form1 : Form
    {
        string sURL;
        string URLbase = "http://emspost.ru/api/rest/?";
        XDocument d;
        LocationNote a;
        IList<Location> loc_cities;
        IList<Location> loc_regions;
        IList<Location> loc_countries;
        IList<Location> loc_cities1;
        IList<Location> loc_regions1;
        float max_weight;
        bool active_calc = false;

        public void Request(int mode)
        {
            WebRequest wrGETURL;
            wrGETURL = WebRequest.Create(sURL);
            Stream objStream = null;
            try
            {
                objStream = wrGETURL.GetResponse().GetResponseStream();
            }
            catch (System.Net.WebException)
            {
                MessageBox.Show("Server offline", "Error", MessageBoxButtons.OK);
                Environment.Exit(0);
            }
            StreamReader objReader = new StreamReader(objStream);

            if (mode == 0)
            {
                d = JsonConvert.DeserializeXNode(objReader.ReadLine());

                if (d.Root.Elements().First().Value != "ok")
                {
                    MessageBox.Show("Error code=" + d.Root.Elements().Last().Elements().First().Value + "; message=\"" + d.Root.Elements().Last().Elements().Last().Value + "\"", d.Root.Elements().First().Value, MessageBoxButtons.OK);
                    Environment.Exit(0);
                }
            }
            else if (mode == 1)
            {
                try
                {
                    a = JsonConvert.DeserializeObject<LocationNote>(objReader.ReadLine());
                }
                catch
                {
                    MessageBox.Show("fail");
                    Environment.Exit(0);
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
            sURL = URLbase + "method=ems.test.echo";
            Request(0);

            sURL = URLbase + "method=ems.get.locations&type=cities&plain=true";
            Request(1);
            loc_cities = a.rsp.locations;

            sURL = URLbase + "method=ems.get.locations&type=regions&plain=true";
            Request(1);
            loc_regions = a.rsp.locations;

            sURL = URLbase + "method=ems.get.locations&type=countries&plain=true";
            Request(1);
            loc_countries = a.rsp.locations;

            loc_cities1 = new List<Location>(loc_cities);
            loc_regions1 = new List<Location>(loc_regions);

            comboBoxFrom.DataSource = loc_cities;
            comboBoxFrom.ValueMember = "name";

            comboBoxTo.DataSource = loc_cities1;
            comboBoxTo.ValueMember = "name";

            sURL = URLbase + "method=ems.get.max.weight";
            Request(0);
            CultureInfo ci = (CultureInfo)CultureInfo.CurrentCulture.Clone();
            ci.NumberFormat.CurrencyDecimalSeparator = ".";
            max_weight = float.Parse(d.Root.Elements().Last().Value, NumberStyles.Any, ci);
            labelMaxWeight.Text = "Вес посылки (до " + max_weight.ToString() + " кг)";
            numericUpDownWeight.Maximum = (decimal)max_weight;

            active_calc = true;
            button1_Click(null, EventArgs.Empty);
        }

        private void radioButtonCities_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCities.Checked)
                comboBoxFrom.DataSource = loc_cities;
            button1_Click(null, EventArgs.Empty);
        }

        private void radioButtonRegions_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonRegions.Checked)
                comboBoxFrom.DataSource = loc_regions;
        }

        private void radioButtonCitiesTo_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCitiesTo.Checked)
            {
                comboBoxTo.DataSource = loc_cities1;
                button1_Click(null, EventArgs.Empty);
            }
        }

        private void radioButtonRegionTo_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonRegionTo.Checked)
            {
                comboBoxTo.DataSource = loc_regions1;
                button1_Click(null, EventArgs.Empty);
            }
        }

        private void radioButtonCountryTo_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCountryTo.Checked)
            {
                comboBoxTo.DataSource = loc_countries;
                groupBoxFromType.Enabled = false;
                comboBoxFrom.Enabled = false;
                groupBoxGoodsType.Enabled = true;
                button1_Click(null, EventArgs.Empty);
            }
            else
            {
                groupBoxFromType.Enabled = true;
                comboBoxFrom.Enabled = true;
                radioButtonAtt.Checked = true;
                groupBoxGoodsType.Enabled = false;
            }
        }

        private void radioButtonAtt_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonAtt.Checked)
            {
                numericUpDownWeight.Maximum = (decimal)max_weight;
                labelMaxWeight.Text = "Вес посылки (до " + max_weight.ToString() + " кг)";
            }
            else
            {
                numericUpDownWeight.Maximum = 2;
                labelMaxWeight.Text = "Вес посылки (до 2.0 кг)";
            }
            button1_Click(null, EventArgs.Empty);
        }

        private void calculation(int mode)
        {
            if (mode == 0)
            {
                Location l1 = (Location)comboBoxFrom.SelectedItem;
                Location l2 = (Location)comboBoxTo.SelectedItem;
                sURL = URLbase + "method=ems.calculate&from=" + l1.value + "&to=" + l2.value + "&weight=" + numericUpDownWeight.Value.ToString(CultureInfo.GetCultureInfo("en-US"));
                Request(0);
                int price = int.Parse(d.Root.Elements().Skip(1).First().Value);
                int min = int.Parse(d.Root.Elements().Skip(2).Elements().First().Value);
                int max = int.Parse(d.Root.Elements().Skip(2).Elements().Last().Value);
                labelPrice.Text = "Цена доставки: " + price + " руб";
                labelMinDays.Text = "Минимальный срок доставки: " + min + " дней";
                labelMaxDays.Text = "Максимальный срок доставки: " + max + " дней";
            }
            else if (mode == 1)
            {
                Location l2 = (Location)comboBoxTo.SelectedItem;
                sURL = URLbase + "method=ems.calculate&to=" + l2.value + 
                    "&weight=" + numericUpDownWeight.Value.ToString(CultureInfo.GetCultureInfo("en-US")) + 
                    "&type=" + (radioButtonAtt.Checked ? "att" : "doc");
                Request(0);
                int price = int.Parse(d.Root.Elements().Skip(1).First().Value);
                labelPrice.Text = "Цена доставки: " + price + " руб";
                labelMinDays.Text = "Минимальный срок доставки: - дней";
                labelMaxDays.Text = "Максимальный срок доставки: - дней";
            }
        }

        private void numericUpDownWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals('.') || e.KeyChar.Equals(','))
            {
                e.KeyChar = ((CultureInfo)CultureInfo.CurrentCulture).NumberFormat.NumberDecimalSeparator.ToCharArray()[0];
            } 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (active_calc)
            {
                int mode = radioButtonCountryTo.Checked ? 1 : 0;
                calculation(mode);
            }
        }

        private void comboBoxFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1_Click(null, EventArgs.Empty);
        }

        private void comboBoxTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1_Click(null, EventArgs.Empty);
        }

        private void numericUpDownWeight_ValueChanged(object sender, EventArgs e)
        {
            button1_Click(null, EventArgs.Empty);
        }
    }
    public class LocationNote
    {
        public Rsp rsp { get; set; }
    }

    public struct Rsp
    {
        public string stat { get; set; }
        public IList<Location> locations { get; set; }
    }

    public struct Location
    {
        public string value { get; set; }
        public string name { get; set; }
        public Type type { get; set; }
    }

    public enum Type { cities, regions, countries };
}
