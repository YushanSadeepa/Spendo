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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
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
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.lblHighestCategory = new System.Windows.Forms.Label();
            this.lblReportTotal = new System.Windows.Forms.Label();
            this.chartCategory = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvReportExpenses = new System.Windows.Forms.DataGridView();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.chartMonthComparison = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1.SuspendLayout();
            this.tabHome.SuspendLayout();
            this.groupBox5.SuspendLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.chartMonthComparison)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabHome);
            this.tabControl1.Controls.Add(this.tabAddExpense);
            this.tabControl1.Controls.Add(this.tabReports);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1206, 563);
            this.tabControl1.TabIndex = 0;
            // 
            // tabHome
            // 
            this.tabHome.BackColor = System.Drawing.Color.Transparent;
            this.tabHome.Controls.Add(this.groupBox5);
            this.tabHome.Controls.Add(this.groupBox4);
            this.tabHome.Controls.Add(this.groupBox3);
            this.tabHome.Location = new System.Drawing.Point(4, 25);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabHome.Size = new System.Drawing.Size(1198, 534);
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
            this.dgvRecentExpenses.Location = new System.Drawing.Point(3, 18);
            this.dgvRecentExpenses.Name = "dgvRecentExpenses";
            this.dgvRecentExpenses.RowHeadersWidth = 51;
            this.dgvRecentExpenses.RowTemplate.Height = 24;
            this.dgvRecentExpenses.Size = new System.Drawing.Size(592, 248);
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
            this.lblTotalExpense.Size = new System.Drawing.Size(104, 16);
            this.lblTotalExpense.TabIndex = 0;
            this.lblTotalExpense.Text = "Total Expenses:";
            // 
            // lblTopCategory
            // 
            this.lblTopCategory.AutoSize = true;
            this.lblTopCategory.Location = new System.Drawing.Point(6, 161);
            this.lblTopCategory.Name = "lblTopCategory";
            this.lblTopCategory.Size = new System.Drawing.Size(93, 16);
            this.lblTopCategory.TabIndex = 2;
            this.lblTopCategory.Text = "Top Catogery:";
            // 
            // lblThisMonthExpense
            // 
            this.lblThisMonthExpense.AutoSize = true;
            this.lblThisMonthExpense.Location = new System.Drawing.Point(6, 109);
            this.lblThisMonthExpense.Name = "lblThisMonthExpense";
            this.lblThisMonthExpense.Size = new System.Drawing.Size(82, 16);
            this.lblThisMonthExpense.TabIndex = 1;
            this.lblThisMonthExpense.Text = "This Mounth:";
            this.lblThisMonthExpense.Click += new System.EventHandler(this.lblThisMonthExpense_Click);
            // 
            // tabAddExpense
            // 
            this.tabAddExpense.Controls.Add(this.groupBox2);
            this.tabAddExpense.Controls.Add(this.grpAddExpense);
            this.tabAddExpense.Location = new System.Drawing.Point(4, 25);
            this.tabAddExpense.Name = "tabAddExpense";
            this.tabAddExpense.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddExpense.Size = new System.Drawing.Size(1198, 534);
            this.tabAddExpense.TabIndex = 1;
            this.tabAddExpense.Text = "➕ Add Expense";
            this.tabAddExpense.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(556, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(631, 517);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recent Expenses";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 18);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(625, 496);
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
            this.grpAddExpense.Size = new System.Drawing.Size(532, 517);
            this.grpAddExpense.TabIndex = 0;
            this.grpAddExpense.TabStop = false;
            this.grpAddExpense.Text = "Add New Expense";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(352, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(117, 395);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
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
            this.nudAmount.Size = new System.Drawing.Size(310, 22);
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
            this.cmbCategory.Size = new System.Drawing.Size(311, 24);
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
            this.dtpExpenseDate.Size = new System.Drawing.Size(310, 22);
            this.dtpExpenseDate.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Catogery:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Description:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Amount:";
            // 
            // tabReports
            // 
            this.tabReports.Controls.Add(this.btnExportExcel);
            this.tabReports.Controls.Add(this.lblHighestCategory);
            this.tabReports.Controls.Add(this.lblReportTotal);
            this.tabReports.Controls.Add(this.chartCategory);
            this.tabReports.Controls.Add(this.dgvReportExpenses);
            this.tabReports.Controls.Add(this.cmbMonth);
            this.tabReports.Location = new System.Drawing.Point(4, 25);
            this.tabReports.Name = "tabReports";
            this.tabReports.Size = new System.Drawing.Size(1198, 534);
            this.tabReports.TabIndex = 2;
            this.tabReports.Text = "📊 Reports";
            this.tabReports.UseVisualStyleBackColor = true;
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Location = new System.Drawing.Point(44, 244);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(75, 50);
            this.btnExportExcel.TabIndex = 7;
            this.btnExportExcel.Text = "Export";
            this.btnExportExcel.UseVisualStyleBackColor = true;
            // 
            // lblHighestCategory
            // 
            this.lblHighestCategory.AutoSize = true;
            this.lblHighestCategory.Location = new System.Drawing.Point(41, 198);
            this.lblHighestCategory.Name = "lblHighestCategory";
            this.lblHighestCategory.Size = new System.Drawing.Size(44, 16);
            this.lblHighestCategory.TabIndex = 4;
            this.lblHighestCategory.Text = "label2";
            // 
            // lblReportTotal
            // 
            this.lblReportTotal.AutoSize = true;
            this.lblReportTotal.Location = new System.Drawing.Point(41, 116);
            this.lblReportTotal.Name = "lblReportTotal";
            this.lblReportTotal.Size = new System.Drawing.Size(44, 16);
            this.lblReportTotal.TabIndex = 3;
            this.lblReportTotal.Text = "label1";
            // 
            // chartCategory
            // 
            chartArea2.Name = "ChartArea1";
            this.chartCategory.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartCategory.Legends.Add(legend2);
            this.chartCategory.Location = new System.Drawing.Point(601, 13);
            this.chartCategory.Name = "chartCategory";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartCategory.Series.Add(series1);
            this.chartCategory.Size = new System.Drawing.Size(586, 267);
            this.chartCategory.TabIndex = 2;
            this.chartCategory.Text = "chart1";
            // 
            // dgvReportExpenses
            // 
            this.dgvReportExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportExpenses.Location = new System.Drawing.Point(604, 312);
            this.dgvReportExpenses.Name = "dgvReportExpenses";
            this.dgvReportExpenses.RowHeadersWidth = 51;
            this.dgvReportExpenses.RowTemplate.Height = 24;
            this.dgvReportExpenses.Size = new System.Drawing.Size(583, 185);
            this.dgvReportExpenses.TabIndex = 1;
            // 
            // cmbMonth
            // 
            this.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Location = new System.Drawing.Point(44, 38);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(121, 24);
            this.cmbMonth.TabIndex = 0;
            // 
            // chartMonthComparison
            // 
            chartArea1.Name = "ChartArea1";
            this.chartMonthComparison.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartMonthComparison.Legends.Add(legend1);
            this.chartMonthComparison.Location = new System.Drawing.Point(6, 21);
            this.chartMonthComparison.Name = "chartMonthComparison";
            this.chartMonthComparison.Size = new System.Drawing.Size(560, 486);
            this.chartMonthComparison.TabIndex = 0;
            this.chartMonthComparison.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "This Month vs Last Month Expenses";
            this.chartMonthComparison.Titles.Add(title1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 562);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabHome.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
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
            ((System.ComponentModel.ISupportInitialize)(this.chartMonthComparison)).EndInit();
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
        private System.Windows.Forms.Label lblHighestCategory;
        private System.Windows.Forms.Label lblReportTotal;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMonthComparison;
    }
}

