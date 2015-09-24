namespace EMS_gui
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxFrom = new System.Windows.Forms.ComboBox();
            this.groupBoxFromType = new System.Windows.Forms.GroupBox();
            this.radioButtonRegions = new System.Windows.Forms.RadioButton();
            this.radioButtonCities = new System.Windows.Forms.RadioButton();
            this.groupBoxToType = new System.Windows.Forms.GroupBox();
            this.radioButtonCountryTo = new System.Windows.Forms.RadioButton();
            this.radioButtonRegionTo = new System.Windows.Forms.RadioButton();
            this.radioButtonCitiesTo = new System.Windows.Forms.RadioButton();
            this.comboBoxTo = new System.Windows.Forms.ComboBox();
            this.labelMaxWeight = new System.Windows.Forms.Label();
            this.groupBoxGoodsType = new System.Windows.Forms.GroupBox();
            this.radioButtonDoc = new System.Windows.Forms.RadioButton();
            this.radioButtonAtt = new System.Windows.Forms.RadioButton();
            this.numericUpDownWeight = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelMaxDays = new System.Windows.Forms.Label();
            this.labelMinDays = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.groupBoxFromType.SuspendLayout();
            this.groupBoxToType.SuspendLayout();
            this.groupBoxGoodsType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxFrom
            // 
            this.comboBoxFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxFrom.Location = new System.Drawing.Point(12, 162);
            this.comboBoxFrom.Name = "comboBoxFrom";
            this.comboBoxFrom.Size = new System.Drawing.Size(401, 28);
            this.comboBoxFrom.TabIndex = 0;
            this.comboBoxFrom.SelectedIndexChanged += new System.EventHandler(this.comboBoxFrom_SelectedIndexChanged);
            // 
            // groupBoxFromType
            // 
            this.groupBoxFromType.Controls.Add(this.radioButtonRegions);
            this.groupBoxFromType.Controls.Add(this.radioButtonCities);
            this.groupBoxFromType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxFromType.Location = new System.Drawing.Point(12, 12);
            this.groupBoxFromType.Name = "groupBoxFromType";
            this.groupBoxFromType.Size = new System.Drawing.Size(401, 115);
            this.groupBoxFromType.TabIndex = 1;
            this.groupBoxFromType.TabStop = false;
            this.groupBoxFromType.Text = "Тип места отправления";
            // 
            // radioButtonRegions
            // 
            this.radioButtonRegions.AutoSize = true;
            this.radioButtonRegions.Location = new System.Drawing.Point(7, 50);
            this.radioButtonRegions.Name = "radioButtonRegions";
            this.radioButtonRegions.Size = new System.Drawing.Size(89, 24);
            this.radioButtonRegions.TabIndex = 1;
            this.radioButtonRegions.Text = "Регион";
            this.radioButtonRegions.UseVisualStyleBackColor = true;
            this.radioButtonRegions.CheckedChanged += new System.EventHandler(this.radioButtonRegions_CheckedChanged);
            // 
            // radioButtonCities
            // 
            this.radioButtonCities.AutoSize = true;
            this.radioButtonCities.Checked = true;
            this.radioButtonCities.Location = new System.Drawing.Point(7, 22);
            this.radioButtonCities.Name = "radioButtonCities";
            this.radioButtonCities.Size = new System.Drawing.Size(82, 24);
            this.radioButtonCities.TabIndex = 0;
            this.radioButtonCities.TabStop = true;
            this.radioButtonCities.Text = "Город";
            this.radioButtonCities.UseVisualStyleBackColor = true;
            this.radioButtonCities.CheckedChanged += new System.EventHandler(this.radioButtonCities_CheckedChanged);
            // 
            // groupBoxToType
            // 
            this.groupBoxToType.Controls.Add(this.radioButtonCountryTo);
            this.groupBoxToType.Controls.Add(this.radioButtonRegionTo);
            this.groupBoxToType.Controls.Add(this.radioButtonCitiesTo);
            this.groupBoxToType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxToType.Location = new System.Drawing.Point(419, 12);
            this.groupBoxToType.Name = "groupBoxToType";
            this.groupBoxToType.Size = new System.Drawing.Size(401, 115);
            this.groupBoxToType.TabIndex = 2;
            this.groupBoxToType.TabStop = false;
            this.groupBoxToType.Text = "Тип места получения";
            // 
            // radioButtonCountryTo
            // 
            this.radioButtonCountryTo.AutoSize = true;
            this.radioButtonCountryTo.Location = new System.Drawing.Point(7, 78);
            this.radioButtonCountryTo.Name = "radioButtonCountryTo";
            this.radioButtonCountryTo.Size = new System.Drawing.Size(92, 24);
            this.radioButtonCountryTo.TabIndex = 2;
            this.radioButtonCountryTo.Text = "Страна";
            this.radioButtonCountryTo.UseVisualStyleBackColor = true;
            this.radioButtonCountryTo.CheckedChanged += new System.EventHandler(this.radioButtonCountryTo_CheckedChanged);
            // 
            // radioButtonRegionTo
            // 
            this.radioButtonRegionTo.AutoSize = true;
            this.radioButtonRegionTo.Location = new System.Drawing.Point(7, 50);
            this.radioButtonRegionTo.Name = "radioButtonRegionTo";
            this.radioButtonRegionTo.Size = new System.Drawing.Size(89, 24);
            this.radioButtonRegionTo.TabIndex = 1;
            this.radioButtonRegionTo.Text = "Регион";
            this.radioButtonRegionTo.UseVisualStyleBackColor = true;
            this.radioButtonRegionTo.CheckedChanged += new System.EventHandler(this.radioButtonRegionTo_CheckedChanged);
            // 
            // radioButtonCitiesTo
            // 
            this.radioButtonCitiesTo.AutoSize = true;
            this.radioButtonCitiesTo.Checked = true;
            this.radioButtonCitiesTo.Location = new System.Drawing.Point(7, 22);
            this.radioButtonCitiesTo.Name = "radioButtonCitiesTo";
            this.radioButtonCitiesTo.Size = new System.Drawing.Size(82, 24);
            this.radioButtonCitiesTo.TabIndex = 0;
            this.radioButtonCitiesTo.TabStop = true;
            this.radioButtonCitiesTo.Text = "Город";
            this.radioButtonCitiesTo.UseVisualStyleBackColor = true;
            this.radioButtonCitiesTo.CheckedChanged += new System.EventHandler(this.radioButtonCitiesTo_CheckedChanged);
            // 
            // comboBoxTo
            // 
            this.comboBoxTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxTo.Location = new System.Drawing.Point(419, 162);
            this.comboBoxTo.Name = "comboBoxTo";
            this.comboBoxTo.Size = new System.Drawing.Size(401, 28);
            this.comboBoxTo.TabIndex = 3;
            this.comboBoxTo.SelectedIndexChanged += new System.EventHandler(this.comboBoxTo_SelectedIndexChanged);
            // 
            // labelMaxWeight
            // 
            this.labelMaxWeight.AutoSize = true;
            this.labelMaxWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMaxWeight.Location = new System.Drawing.Point(416, 218);
            this.labelMaxWeight.Name = "labelMaxWeight";
            this.labelMaxWeight.Size = new System.Drawing.Size(21, 20);
            this.labelMaxWeight.TabIndex = 4;
            this.labelMaxWeight.Text = "--";
            // 
            // groupBoxGoodsType
            // 
            this.groupBoxGoodsType.Controls.Add(this.radioButtonDoc);
            this.groupBoxGoodsType.Controls.Add(this.radioButtonAtt);
            this.groupBoxGoodsType.Enabled = false;
            this.groupBoxGoodsType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxGoodsType.Location = new System.Drawing.Point(12, 192);
            this.groupBoxGoodsType.Name = "groupBoxGoodsType";
            this.groupBoxGoodsType.Size = new System.Drawing.Size(401, 85);
            this.groupBoxGoodsType.TabIndex = 5;
            this.groupBoxGoodsType.TabStop = false;
            this.groupBoxGoodsType.Text = "Тип посылки";
            // 
            // radioButtonDoc
            // 
            this.radioButtonDoc.AutoSize = true;
            this.radioButtonDoc.Location = new System.Drawing.Point(7, 50);
            this.radioButtonDoc.Name = "radioButtonDoc";
            this.radioButtonDoc.Size = new System.Drawing.Size(124, 24);
            this.radioButtonDoc.TabIndex = 1;
            this.radioButtonDoc.Text = "Документы";
            this.radioButtonDoc.UseVisualStyleBackColor = true;
            // 
            // radioButtonAtt
            // 
            this.radioButtonAtt.AutoSize = true;
            this.radioButtonAtt.Checked = true;
            this.radioButtonAtt.Location = new System.Drawing.Point(7, 22);
            this.radioButtonAtt.Name = "radioButtonAtt";
            this.radioButtonAtt.Size = new System.Drawing.Size(92, 24);
            this.radioButtonAtt.TabIndex = 0;
            this.radioButtonAtt.TabStop = true;
            this.radioButtonAtt.Text = "Товары";
            this.radioButtonAtt.UseVisualStyleBackColor = true;
            this.radioButtonAtt.CheckedChanged += new System.EventHandler(this.radioButtonAtt_CheckedChanged);
            // 
            // numericUpDownWeight
            // 
            this.numericUpDownWeight.DecimalPlaces = 1;
            this.numericUpDownWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownWeight.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownWeight.Location = new System.Drawing.Point(419, 251);
            this.numericUpDownWeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownWeight.Name = "numericUpDownWeight";
            this.numericUpDownWeight.Size = new System.Drawing.Size(401, 26);
            this.numericUpDownWeight.TabIndex = 6;
            this.numericUpDownWeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownWeight.ValueChanged += new System.EventHandler(this.numericUpDownWeight_ValueChanged);
            this.numericUpDownWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericUpDownWeight_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Откуда";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(423, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Куда";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelMaxDays);
            this.groupBox1.Controls.Add(this.labelMinDays);
            this.groupBox1.Controls.Add(this.labelPrice);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 284);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 125);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Расчёты";
            // 
            // labelMaxDays
            // 
            this.labelMaxDays.AutoSize = true;
            this.labelMaxDays.Location = new System.Drawing.Point(13, 79);
            this.labelMaxDays.Name = "labelMaxDays";
            this.labelMaxDays.Size = new System.Drawing.Size(326, 20);
            this.labelMaxDays.TabIndex = 2;
            this.labelMaxDays.Text = "Максимальный срок доставки: - дней";
            // 
            // labelMinDays
            // 
            this.labelMinDays.AutoSize = true;
            this.labelMinDays.Location = new System.Drawing.Point(13, 53);
            this.labelMinDays.Name = "labelMinDays";
            this.labelMinDays.Size = new System.Drawing.Size(318, 20);
            this.labelMinDays.TabIndex = 1;
            this.labelMinDays.Text = "Минимальный срок доставки: - дней";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(13, 26);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(186, 20);
            this.labelPrice.TabIndex = 0;
            this.labelPrice.Text = "Цена доставки: - руб";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 426);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownWeight);
            this.Controls.Add(this.groupBoxGoodsType);
            this.Controls.Add(this.labelMaxWeight);
            this.Controls.Add(this.comboBoxTo);
            this.Controls.Add(this.groupBoxToType);
            this.Controls.Add(this.groupBoxFromType);
            this.Controls.Add(this.comboBoxFrom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Калькулятор стоимости и срока доставки EMS";
            this.groupBoxFromType.ResumeLayout(false);
            this.groupBoxFromType.PerformLayout();
            this.groupBoxToType.ResumeLayout(false);
            this.groupBoxToType.PerformLayout();
            this.groupBoxGoodsType.ResumeLayout(false);
            this.groupBoxGoodsType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxFrom;
        private System.Windows.Forms.GroupBox groupBoxFromType;
        private System.Windows.Forms.RadioButton radioButtonRegions;
        private System.Windows.Forms.RadioButton radioButtonCities;
        private System.Windows.Forms.GroupBox groupBoxToType;
        private System.Windows.Forms.RadioButton radioButtonCountryTo;
        private System.Windows.Forms.RadioButton radioButtonRegionTo;
        private System.Windows.Forms.RadioButton radioButtonCitiesTo;
        private System.Windows.Forms.ComboBox comboBoxTo;
        private System.Windows.Forms.Label labelMaxWeight;
        private System.Windows.Forms.GroupBox groupBoxGoodsType;
        private System.Windows.Forms.RadioButton radioButtonDoc;
        private System.Windows.Forms.RadioButton radioButtonAtt;
        private System.Windows.Forms.NumericUpDown numericUpDownWeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelMinDays;
        private System.Windows.Forms.Label labelMaxDays;
    }
}

