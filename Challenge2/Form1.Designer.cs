namespace Challenge2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ChartProm = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ChartSelSex = new System.Windows.Forms.ComboBox();
            this.SelPer = new System.Windows.Forms.ComboBox();
            this.SelAge = new System.Windows.Forms.ComboBox();
            this.SelSex = new System.Windows.Forms.ComboBox();
            this.TotalProm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.txtPeriodo = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtSexoPeriodo = new System.Windows.Forms.TextBox();
            this.SelPer2 = new System.Windows.Forms.ComboBox();
            this.SelSex2 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GralTable = new System.Windows.Forms.DataGridView();
            this.Rst_Table = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Add_Menu = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NumPelis = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.AddAño = new System.Windows.Forms.ComboBox();
            this.AddMes = new System.Windows.Forms.ComboBox();
            this.RbO = new System.Windows.Forms.RadioButton();
            this.RbF = new System.Windows.Forms.RadioButton();
            this.RbM = new System.Windows.Forms.RadioButton();
            this.AddNacimiento = new System.Windows.Forms.DateTimePicker();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.ChartProm)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GralTable)).BeginInit();
            this.Add_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumPelis)).BeginInit();
            this.SuspendLayout();
            // 
            // ChartProm
            // 
            chartArea1.AxisX2.IsInterlaced = true;
            chartArea1.Name = "ChartArea1";
            this.ChartProm.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ChartProm.Legends.Add(legend1);
            this.ChartProm.Location = new System.Drawing.Point(42, 25);
            this.ChartProm.Name = "ChartProm";
            series1.ChartArea = "ChartArea1";
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.ChartProm.Series.Add(series1);
            this.ChartProm.Size = new System.Drawing.Size(445, 289);
            this.ChartProm.TabIndex = 0;
            this.ChartProm.Text = "chart1";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Por sexo",
            "Por periodo",
            "Por edad",
            "Por sexo y periodo"});
            this.comboBox1.Location = new System.Drawing.Point(347, 309);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(140, 23);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "Promedio peliculas";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ChartSelSex
            // 
            this.ChartSelSex.FormattingEnabled = true;
            this.ChartSelSex.Items.AddRange(new object[] {
            "M",
            "F",
            "O"});
            this.ChartSelSex.Location = new System.Drawing.Point(430, 338);
            this.ChartSelSex.Name = "ChartSelSex";
            this.ChartSelSex.Size = new System.Drawing.Size(57, 23);
            this.ChartSelSex.TabIndex = 2;
            this.ChartSelSex.Visible = false;
            this.ChartSelSex.SelectedIndexChanged += new System.EventHandler(this.ChartSelSex_SelectedIndexChanged);
            // 
            // SelPer
            // 
            this.SelPer.DropDownHeight = 100;
            this.SelPer.DropDownWidth = 110;
            this.SelPer.FormattingEnabled = true;
            this.SelPer.IntegralHeight = false;
            this.SelPer.Location = new System.Drawing.Point(515, 160);
            this.SelPer.Name = "SelPer";
            this.SelPer.Size = new System.Drawing.Size(121, 23);
            this.SelPer.TabIndex = 4;
            this.SelPer.Text = "Periodo";
            this.SelPer.SelectedIndexChanged += new System.EventHandler(this.SelPer_SelectedIndexChanged);
            // 
            // SelAge
            // 
            this.SelAge.DropDownHeight = 100;
            this.SelAge.DropDownWidth = 110;
            this.SelAge.FormattingEnabled = true;
            this.SelAge.IntegralHeight = false;
            this.SelAge.Location = new System.Drawing.Point(515, 209);
            this.SelAge.Name = "SelAge";
            this.SelAge.Size = new System.Drawing.Size(121, 23);
            this.SelAge.TabIndex = 5;
            this.SelAge.Text = "Edad";
            this.SelAge.SelectedIndexChanged += new System.EventHandler(this.SelAge_SelectedIndexChanged);
            // 
            // SelSex
            // 
            this.SelSex.FormattingEnabled = true;
            this.SelSex.Items.AddRange(new object[] {
            "M",
            "F",
            "O"});
            this.SelSex.Location = new System.Drawing.Point(515, 109);
            this.SelSex.Name = "SelSex";
            this.SelSex.Size = new System.Drawing.Size(121, 23);
            this.SelSex.TabIndex = 6;
            this.SelSex.Text = "Sexo";
            this.SelSex.SelectedIndexChanged += new System.EventHandler(this.SelSex_SelectedIndexChanged);
            // 
            // TotalProm
            // 
            this.TotalProm.BackColor = System.Drawing.Color.LemonChiffon;
            this.TotalProm.Font = new System.Drawing.Font("Segoe UI", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.TotalProm.ForeColor = System.Drawing.Color.ForestGreen;
            this.TotalProm.Location = new System.Drawing.Point(618, 43);
            this.TotalProm.Name = "TotalProm";
            this.TotalProm.ReadOnly = true;
            this.TotalProm.Size = new System.Drawing.Size(66, 43);
            this.TotalProm.TabIndex = 7;
            this.TotalProm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(596, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Promedio historico";
            // 
            // txtSexo
            // 
            this.txtSexo.Location = new System.Drawing.Point(670, 109);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(100, 23);
            this.txtSexo.TabIndex = 9;
            // 
            // txtPeriodo
            // 
            this.txtPeriodo.Location = new System.Drawing.Point(670, 160);
            this.txtPeriodo.Name = "txtPeriodo";
            this.txtPeriodo.Size = new System.Drawing.Size(100, 23);
            this.txtPeriodo.TabIndex = 10;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(670, 209);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(100, 23);
            this.txtEdad.TabIndex = 11;
            // 
            // txtSexoPeriodo
            // 
            this.txtSexoPeriodo.Location = new System.Drawing.Point(155, 60);
            this.txtSexoPeriodo.Name = "txtSexoPeriodo";
            this.txtSexoPeriodo.Size = new System.Drawing.Size(100, 23);
            this.txtSexoPeriodo.TabIndex = 12;
            // 
            // SelPer2
            // 
            this.SelPer2.DropDownHeight = 100;
            this.SelPer2.DropDownWidth = 110;
            this.SelPer2.FormattingEnabled = true;
            this.SelPer2.IntegralHeight = false;
            this.SelPer2.Location = new System.Drawing.Point(6, 77);
            this.SelPer2.Name = "SelPer2";
            this.SelPer2.Size = new System.Drawing.Size(121, 23);
            this.SelPer2.TabIndex = 13;
            this.SelPer2.Text = "Periodo";
            this.SelPer2.SelectedIndexChanged += new System.EventHandler(this.SelPer2_SelectedIndexChanged);
            // 
            // SelSex2
            // 
            this.SelSex2.AutoCompleteCustomSource.AddRange(new string[] {
            "M",
            "F",
            "O"});
            this.SelSex2.FormattingEnabled = true;
            this.SelSex2.Items.AddRange(new object[] {
            "M",
            "F",
            "O"});
            this.SelSex2.Location = new System.Drawing.Point(6, 37);
            this.SelSex2.Name = "SelSex2";
            this.SelSex2.Size = new System.Drawing.Size(121, 23);
            this.SelSex2.TabIndex = 14;
            this.SelSex2.Text = "Sexo";
            this.SelSex2.SelectedIndexChanged += new System.EventHandler(this.SelSex2_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SelSex2);
            this.groupBox1.Controls.Add(this.txtSexoPeriodo);
            this.groupBox1.Controls.Add(this.SelPer2);
            this.groupBox1.Location = new System.Drawing.Point(515, 261);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 122);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Promedio por Sexo y Periodo";
            // 
            // GralTable
            // 
            this.GralTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GralTable.Location = new System.Drawing.Point(42, 425);
            this.GralTable.Name = "GralTable";
            this.GralTable.RowTemplate.Height = 25;
            this.GralTable.Size = new System.Drawing.Size(575, 203);
            this.GralTable.TabIndex = 16;
            // 
            // Rst_Table
            // 
            this.Rst_Table.Location = new System.Drawing.Point(42, 396);
            this.Rst_Table.Name = "Rst_Table";
            this.Rst_Table.Size = new System.Drawing.Size(75, 23);
            this.Rst_Table.TabIndex = 17;
            this.Rst_Table.Text = "Reset Table";
            this.Rst_Table.UseVisualStyleBackColor = true;
            this.Rst_Table.Click += new System.EventHandler(this.Rst_Table_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Menu;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Image = global::Challenge2.Properties.Resources.green_add_button_12023;
            this.button1.Location = new System.Drawing.Point(670, 482);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 81);
            this.button1.TabIndex = 18;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Add_Menu
            // 
            this.Add_Menu.BackColor = System.Drawing.Color.Gainsboro;
            this.Add_Menu.Controls.Add(this.label5);
            this.Add_Menu.Controls.Add(this.label4);
            this.Add_Menu.Controls.Add(this.label3);
            this.Add_Menu.Controls.Add(this.NumPelis);
            this.Add_Menu.Controls.Add(this.label6);
            this.Add_Menu.Controls.Add(this.AddAño);
            this.Add_Menu.Controls.Add(this.AddMes);
            this.Add_Menu.Controls.Add(this.RbO);
            this.Add_Menu.Controls.Add(this.RbF);
            this.Add_Menu.Controls.Add(this.RbM);
            this.Add_Menu.Controls.Add(this.AddNacimiento);
            this.Add_Menu.Controls.Add(this.BtnExit);
            this.Add_Menu.Controls.Add(this.BtnAdd);
            this.Add_Menu.Controls.Add(this.label2);
            this.Add_Menu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Add_Menu.Location = new System.Drawing.Point(208, 160);
            this.Add_Menu.Name = "Add_Menu";
            this.Add_Menu.Size = new System.Drawing.Size(434, 335);
            this.Add_Menu.TabIndex = 19;
            this.Add_Menu.TabStop = false;
            this.Add_Menu.Text = "Formulario de encuesta";
            this.Add_Menu.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(45, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Cant. Peliculas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(45, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Periodo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(45, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Genero";
            // 
            // NumPelis
            // 
            this.NumPelis.Location = new System.Drawing.Point(143, 194);
            this.NumPelis.Name = "NumPelis";
            this.NumPelis.Size = new System.Drawing.Size(47, 25);
            this.NumPelis.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(216, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 28);
            this.label6.TabIndex = 12;
            this.label6.Text = "/";
            // 
            // AddAño
            // 
            this.AddAño.FormattingEnabled = true;
            this.AddAño.Items.AddRange(new object[] {
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022"});
            this.AddAño.Location = new System.Drawing.Point(241, 149);
            this.AddAño.Name = "AddAño";
            this.AddAño.Size = new System.Drawing.Size(98, 25);
            this.AddAño.TabIndex = 11;
            this.AddAño.Text = "Año";
            // 
            // AddMes
            // 
            this.AddMes.FormattingEnabled = true;
            this.AddMes.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.AddMes.Location = new System.Drawing.Point(139, 149);
            this.AddMes.Name = "AddMes";
            this.AddMes.Size = new System.Drawing.Size(71, 25);
            this.AddMes.TabIndex = 10;
            this.AddMes.Text = "Mes";
            // 
            // RbO
            // 
            this.RbO.AutoSize = true;
            this.RbO.Location = new System.Drawing.Point(264, 102);
            this.RbO.Name = "RbO";
            this.RbO.Size = new System.Drawing.Size(36, 21);
            this.RbO.TabIndex = 9;
            this.RbO.Text = "O";
            this.RbO.UseVisualStyleBackColor = true;
            // 
            // RbF
            // 
            this.RbF.AutoSize = true;
            this.RbF.Location = new System.Drawing.Point(205, 102);
            this.RbF.Name = "RbF";
            this.RbF.Size = new System.Drawing.Size(32, 21);
            this.RbF.TabIndex = 8;
            this.RbF.Text = "F";
            this.RbF.UseVisualStyleBackColor = true;
            // 
            // RbM
            // 
            this.RbM.AutoSize = true;
            this.RbM.Checked = true;
            this.RbM.Location = new System.Drawing.Point(139, 102);
            this.RbM.Name = "RbM";
            this.RbM.Size = new System.Drawing.Size(38, 21);
            this.RbM.TabIndex = 7;
            this.RbM.TabStop = true;
            this.RbM.Text = "M";
            this.RbM.UseVisualStyleBackColor = true;
            // 
            // AddNacimiento
            // 
            this.AddNacimiento.CalendarForeColor = System.Drawing.SystemColors.ControlDark;
            this.AddNacimiento.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
            this.AddNacimiento.CalendarTrailingForeColor = System.Drawing.SystemColors.ControlDark;
            this.AddNacimiento.CustomFormat = "yyyy-mm-dd";
            this.AddNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.AddNacimiento.Location = new System.Drawing.Point(143, 60);
            this.AddNacimiento.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.AddNacimiento.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.AddNacimiento.Name = "AddNacimiento";
            this.AddNacimiento.Size = new System.Drawing.Size(196, 25);
            this.AddNacimiento.TabIndex = 6;
            this.AddNacimiento.Value = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(264, 253);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(85, 37);
            this.BtnExit.TabIndex = 5;
            this.BtnExit.Text = "Cancelar";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(84, 253);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(93, 37);
            this.BtnAdd.TabIndex = 4;
            this.BtnAdd.Text = "Agregar";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(45, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 34);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fecha de \r\nNacimiento";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 677);
            this.Controls.Add(this.Add_Menu);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Rst_Table);
            this.Controls.Add(this.GralTable);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtPeriodo);
            this.Controls.Add(this.txtSexo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TotalProm);
            this.Controls.Add(this.SelSex);
            this.Controls.Add(this.SelAge);
            this.Controls.Add(this.SelPer);
            this.Controls.Add(this.ChartSelSex);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ChartProm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Challenge2: Encuesta con SQL";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChartProm)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GralTable)).EndInit();
            this.Add_Menu.ResumeLayout(false);
            this.Add_Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumPelis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ChartProm;
        private ComboBox comboBox1;
        private ComboBox ChartSelSex;
        private ComboBox SelPer;
        private ComboBox SelAge;
        private ComboBox SelSex;
        private TextBox textBox1;
        private TextBox TotalProm;
        private Label label1;
        private TextBox txtSexo;
        private TextBox txtPeriodo;
        private TextBox txtEdad;
        private TextBox txtSexoPeriodo;
        private ComboBox SelPer2;
        private ComboBox SelSex2;
        private GroupBox groupBox1;
        private DataGridView GralTable;
        private Button Rst_Table;
        private Button button1;
        private GroupBox Add_Menu;
        private Label label5;
        private Label label4;
        private Label label3;
        private NumericUpDown NumPelis;
        private Label label6;
        private ComboBox AddAño;
        private ComboBox AddMes;
        private RadioButton RbO;
        private RadioButton RbF;
        private RadioButton RbM;
        private DateTimePicker AddNacimiento;
        private Button BtnExit;
        private Button BtnAdd;
        private Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}