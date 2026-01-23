namespace Spendo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea62 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend62 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Title title31 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea61 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend61 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series31 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.chartMonthComparison = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvRecentExpenses = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblTotalExpense = new System.Windows.Forms.Label();
            this.lblTopCategory = new System.Windows.Forms.Label();
            this.lblThisMonthExpense = new System.Windows.Forms.Label();
            this.tabAddExpense = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grpAddExpense = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAddExpense = new System.Windows.Forms.Button();
            this.nudAmount = new System.Windows.Forms.NumericUpDown();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.dtpExpenseDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabReports = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.lblReportTotal = new System.Windows.Forms.Label();
            this.chartCategory = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvReportExpenses = new System.Windows.Forms.DataGridView();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabHome.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMonthComparison)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentExpenses)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tabAddExpense.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpAddExpense.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            this.tabReports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportExpenses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabHome);
            this.tabControl1.Controls.Add(this.tabAddExpense);
            this.tabControl1.Controls.Add(this.tabReports);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(120, 40);
            this.tabControl1.Location = new System.Drawing.Point(2, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1600, 563);
            this.tabControl1.TabIndex = 0;
            // 
            // tabHome
            // 
            this.tabHome.BackColor = System.Drawing.Color.Transparent;
            this.tabHome.Controls.Add(this.groupBox5);
            this.tabHome.Controls.Add(this.groupBox4);
            this.tabHome.Controls.Add(this.groupBox3);
            this.tabHome.Location = new System.Drawing.Point(4, 44);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabHome.Size = new System.Drawing.Size(1592, 515);
            this.tabHome.TabIndex = 0;
            this.tabHome.Text = "🏠 Home";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.chartMonthComparison);
            this.groupBox5.Location = new System.Drawing.Point(615, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox5.Size = new System.Drawing.Size(572, 513);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Analysis";
            // 
            // chartMonthComparison
            // 
            chartArea62.Name = "ChartArea1";
            this.chartMonthComparison.ChartAreas.Add(chartArea62);
            legend62.Name = "Legend1";
            this.chartMonthComparison.Legends.Add(legend62);
            this.chartMonthComparison.Location = new System.Drawing.Point(6, 21);
            this.chartMonthComparison.Name = "chartMonthComparison";
            this.chartMonthComparison.Size = new System.Drawing.Size(560, 486);
            this.chartMonthComparison.TabIndex = 0;
            this.chartMonthComparison.Text = "chart1";
            title31.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title31.Name = "Title1";
            title31.Text = "This Month vs Last Month Expenses";
            this.chartMonthComparison.Titles.Add(title31);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvRecentExpenses);
            this.groupBox4.Location = new System.Drawing.Point(8, 253);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(601, 272);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Recent Expenses";
            // 
            // dgvRecentExpenses
            // 
            this.dgvRecentExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecentExpenses.Location = new System.Drawing.Point(26, 30);
            this.dgvRecentExpenses.Name = "dgvRecentExpenses";
            this.dgvRecentExpenses.RowHeadersWidth = 51;
            this.dgvRecentExpenses.RowTemplate.Height = 24;
            this.dgvRecentExpenses.Size = new System.Drawing.Size(547, 206);
            this.dgvRecentExpenses.TabIndex = 0;
            this.dgvRecentExpenses.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRecentExpenses_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblTotalExpense);
            this.groupBox3.Controls.Add(this.lblTopCategory);
            this.groupBox3.Controls.Add(this.lblThisMonthExpense);
            this.groupBox3.Location = new System.Drawing.Point(8, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(595, 241);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Over view";
            // 
            // lblTotalExpense
            // 
            this.lblTotalExpense.AutoSize = true;
            this.lblTotalExpense.Location = new System.Drawing.Point(6, 65);
            this.lblTotalExpense.Name = "lblTotalExpense";
            this.lblTotalExpense.Size = new System.Drawing.Size(130, 25);
            this.lblTotalExpense.TabIndex = 0;
            this.lblTotalExpense.Text = "Total Expenses:";
            // 
            // lblTopCategory
            // 
            this.lblTopCategory.AutoSize = true;
            this.lblTopCategory.Location = new System.Drawing.Point(6, 161);
            this.lblTopCategory.Name = "lblTopCategory";
            this.lblTopCategory.Size = new System.Drawing.Size(122, 25);
            this.lblTopCategory.TabIndex = 2;
            this.lblTopCategory.Text = "Top Catogery:";
            // 
            // lblThisMonthExpense
            // 
            this.lblThisMonthExpense.AutoSize = true;
            this.lblThisMonthExpense.Location = new System.Drawing.Point(6, 109);
            this.lblThisMonthExpense.Name = "lblThisMonthExpense";
            this.lblThisMonthExpense.Size = new System.Drawing.Size(115, 25);
            this.lblThisMonthExpense.TabIndex = 1;
            this.lblThisMonthExpense.Text = "This Mounth:";
            this.lblThisMonthExpense.Click += new System.EventHandler(this.lblThisMonthExpense_Click);
            // 
            // tabAddExpense
            // 
            this.tabAddExpense.Controls.Add(this.groupBox2);
            this.tabAddExpense.Controls.Add(this.grpAddExpense);
            this.tabAddExpense.Location = new System.Drawing.Point(4, 44);
            this.tabAddExpense.Name = "tabAddExpense";
            this.tabAddExpense.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddExpense.Size = new System.Drawing.Size(1592, 515);
            this.tabAddExpense.TabIndex = 1;
            this.tabAddExpense.Text = "➕ Add Expense";
            this.tabAddExpense.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(568, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(631, 478);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recent Expenses";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(39, 38);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(574, 418);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // grpAddExpense
            // 
            this.grpAddExpense.Controls.Add(this.button1);
            this.grpAddExpense.Controls.Add(this.btnUpdate);
            this.grpAddExpense.Controls.Add(this.btnClear);
            this.grpAddExpense.Controls.Add(this.btnAddExpense);
            this.grpAddExpense.Controls.Add(this.nudAmount);
            this.grpAddExpense.Controls.Add(this.cmbCategory);
            this.grpAddExpense.Controls.Add(this.txtDescription);
            this.grpAddExpense.Controls.Add(this.dtpExpenseDate);
            this.grpAddExpense.Controls.Add(this.label4);
            this.grpAddExpense.Controls.Add(this.label5);
            this.grpAddExpense.Controls.Add(this.label6);
            this.grpAddExpense.Controls.Add(this.label7);
            this.grpAddExpense.Location = new System.Drawing.Point(8, 8);
            this.grpAddExpense.Name = "grpAddExpense";
            this.grpAddExpense.Size = new System.Drawing.Size(532, 478);
            this.grpAddExpense.TabIndex = 0;
            this.grpAddExpense.TabStop = false;
            this.grpAddExpense.Text = "Add New Expense";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(331, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 34);
            this.button1.TabIndex = 14;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Lime;
            this.btnUpdate.Location = new System.Drawing.Point(117, 401);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(96, 34);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(315, 327);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(112, 38);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAddExpense
            // 
            this.btnAddExpense.Location = new System.Drawing.Point(116, 327);
            this.btnAddExpense.Name = "btnAddExpense";
            this.btnAddExpense.Size = new System.Drawing.Size(112, 38);
            this.btnAddExpense.TabIndex = 10;
            this.btnAddExpense.Text = "➕  ";
            this.btnAddExpense.UseVisualStyleBackColor = true;
            this.btnAddExpense.Click += new System.EventHandler(this.btnAddExpense_Click);
            // 
            // nudAmount
            // 
            this.nudAmount.DecimalPlaces = 2;
            this.nudAmount.Location = new System.Drawing.Point(117, 267);
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.Size = new System.Drawing.Size(310, 31);
            this.nudAmount.TabIndex = 9;
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "🏠 Housing / Rent",
            "💡 Utilities",
            "📶 Internet & Mobile",
            "🧾 Bills",
            "🛠 Maintenance",
            "🍔 Food",
            "🛒 Groceries",
            "🚗 Transport",
            "🛠 Vehicle Maintenance",
            "🏥 Medical",
            "🎮 Entertainment",
            "🛍 Shopping",
            "💰 Finance",
            "✈ Travel",
            "🔧 Other"});
            this.cmbCategory.Location = new System.Drawing.Point(116, 220);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(311, 33);
            this.cmbCategory.TabIndex = 8;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(117, 82);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(310, 86);
            this.txtDescription.TabIndex = 7;
            // 
            // dtpExpenseDate
            // 
            this.dtpExpenseDate.Location = new System.Drawing.Point(117, 33);
            this.dtpExpenseDate.Name = "dtpExpenseDate";
            this.dtpExpenseDate.Size = new System.Drawing.Size(310, 31);
            this.dtpExpenseDate.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Catogery:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Description:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "Amount:";
            // 
            // tabReports
            // 
            this.tabReports.Controls.Add(this.pictureBox1);
            this.tabReports.Controls.Add(this.button2);
            this.tabReports.Controls.Add(this.lblReportTotal);
            this.tabReports.Controls.Add(this.chartCategory);
            this.tabReports.Controls.Add(this.dgvReportExpenses);
            this.tabReports.Controls.Add(this.cmbMonth);
            this.tabReports.Location = new System.Drawing.Point(4, 44);
            this.tabReports.Name = "tabReports";
            this.tabReports.Size = new System.Drawing.Size(1592, 515);
            this.tabReports.TabIndex = 2;
            this.tabReports.Text = "📊 Reports";
            this.tabReports.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(58, 98);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(429, 55);
            this.button2.TabIndex = 5;
            this.button2.Text = "Export ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblReportTotal
            // 
            this.lblReportTotal.AutoSize = true;
            this.lblReportTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportTotal.Location = new System.Drawing.Point(54, 39);
            this.lblReportTotal.Name = "lblReportTotal";
            this.lblReportTotal.Size = new System.Drawing.Size(103, 20);
            this.lblReportTotal.TabIndex = 3;
            this.lblReportTotal.Text = "Select Time:";
            // 
            // chartCategory
            // 
            chartArea61.Name = "ChartArea1";
            this.chartCategory.ChartAreas.Add(chartArea61);
            legend61.Name = "Legend1";
            this.chartCategory.Legends.Add(legend61);
            this.chartCategory.Location = new System.Drawing.Point(655, 3);
            this.chartCategory.Name = "chartCategory";
            series31.ChartArea = "ChartArea1";
            series31.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series31.Legend = "Legend1";
            series31.Name = "Series1";
            this.chartCategory.Series.Add(series31);
            this.chartCategory.Size = new System.Drawing.Size(583, 509);
            this.chartCategory.TabIndex = 2;
            this.chartCategory.Text = "chart1";
            // 
            // dgvReportExpenses
            // 
            this.dgvReportExpenses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReportExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportExpenses.Location = new System.Drawing.Point(23, 181);
            this.dgvReportExpenses.Name = "dgvReportExpenses";
            this.dgvReportExpenses.RowHeadersWidth = 51;
            this.dgvReportExpenses.RowTemplate.Height = 24;
            this.dgvReportExpenses.Size = new System.Drawing.Size(572, 322);
            this.dgvReportExpenses.TabIndex = 1;
            // 
            // cmbMonth
            // 
            this.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Location = new System.Drawing.Point(176, 39);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(311, 28);
            this.cmbMonth.TabIndex = 0;
            this.cmbMonth.SelectedIndexChanged += new System.EventHandler(this.cmbMonth_SelectedIndexChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Spendo.Properties.Resources.SPENDO_BOTTUM;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(-1, 566);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(624, 83);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Spendo.Properties.Resources.excell_logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(493, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 51);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(98)))), ((int)(((byte)(108)))));
            this.ClientSize = new System.Drawing.Size(1246, 650);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimumSize = new System.Drawing.Size(1000, 650);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabHome.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartMonthComparison)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentExpenses)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabAddExpense.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpAddExpense.ResumeLayout(false);
            this.grpAddExpense.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            this.tabReports.ResumeLayout(false);
            this.tabReports.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportExpenses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.TabPage tabAddExpense;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox grpAddExpense;
        private System.Windows.Forms.TabPage tabReports;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblTotalExpense;
        private System.Windows.Forms.Label lblTopCategory;
        private System.Windows.Forms.Label lblThisMonthExpense;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dgvRecentExpenses;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAddExpense;
        private System.Windows.Forms.NumericUpDown nudAmount;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.DateTimePicker dtpExpenseDate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCategory;
        private System.Windows.Forms.DataGridView dgvReportExpenses;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.Label lblReportTotal;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMonthComparison;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

