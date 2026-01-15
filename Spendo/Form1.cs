using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using ClosedXML.Excel;





namespace Spendo
{
    public partial class Form1 : Form
    {
        int selectedId = 0;
        Timer chartTimer;
        DataTable dtThisMonth, dtLastMonth;
        int animationIndex = 0;


        string connectionString = @"Data Source=DESKTOP-D5GPCJD\SQLEXPRESS;Initial Catalog=Spendo;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        public Form1()
        {
            InitializeComponent();
            dataGridView1.AllowUserToAddRows = false;
            dgvRecentExpenses.AllowUserToAddRows = false;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecentExpenses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            nudAmount.Maximum = 1000000000;
            nudAmount.DecimalPlaces = 2;

            
            LoadMonths();
            RefreshAllGrids();

        }

        private void chart1_Click(object sender, EventArgs e)
        {
        }

        private void btnAddExpense_Click(object sender, EventArgs e)
        {
            if (cmbCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a category");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query =
                    "INSERT INTO Expenses ([Date], [Description], Category, Amount) " +
                    "VALUES (@Date, @Description, @Category, @Amount)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Date", dtpExpenseDate.Value.Date);
                cmd.Parameters.AddWithValue("@Description", txtDescription.Text);
                cmd.Parameters.AddWithValue("@Category", cmbCategory.Text);
                cmd.Parameters.AddWithValue("@Amount", nudAmount.Value);

                con.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Expense Added Successfully ✅");

            ClearFields();
            RefreshAllGrids();

        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        void ClearFields()
        {
            txtDescription.Clear();
            cmbCategory.SelectedIndex = -1;
            nudAmount.Value = 0;
            dtpExpenseDate.Value = DateTime.Now;

            selectedId = 0;
        }


        void LoadRecentExpenses()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT TOP 10 Id,[Date],[Description],Category,Amount FROM Expenses ORDER BY [Date] DESC";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
                dataGridView1.Columns["Id"].Visible = false;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.MultiSelect = false; // Only one row at a time
            }
        }
        void SelectRow()
        {
            if (dataGridView1.CurrentRow == null)
                return;

            selectedId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);

            dtpExpenseDate.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["Date"].Value);
            txtDescription.Text = dataGridView1.CurrentRow.Cells["Description"].Value.ToString();
            cmbCategory.Text = dataGridView1.CurrentRow.Cells["Category"].Value.ToString();
            nudAmount.Value = Convert.ToDecimal(dataGridView1.CurrentRow.Cells["Amount"].Value);
        }





        void LoadTotalExpense()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT ISNULL(SUM(Amount),0) FROM Expenses";
                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();
                decimal total = Convert.ToDecimal(cmd.ExecuteScalar());

                lblTotalExpense.Text = "Total Expense: Rs. " + total.ToString("N2");
            }
        }

        private void dgvRecentExpenses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // Ignore header clicks
            SelectRow();
        }






        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedId == 0)
            {
                MessageBox.Show("Please select an expense to update");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "UPDATE Expenses SET [Date]=@Date, [Description]=@Desc, Category=@Cat, Amount=@Amt WHERE Id=@Id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Date", dtpExpenseDate.Value.Date);
                cmd.Parameters.AddWithValue("@Desc", txtDescription.Text);
                cmd.Parameters.AddWithValue("@Cat", cmbCategory.Text);
                cmd.Parameters.AddWithValue("@Amt", nudAmount.Value);
                cmd.Parameters.AddWithValue("@Id", selectedId);

                con.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Expense Updated ✅");
            ClearFields();
           
            RefreshAllGrids();

        }




        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedId == 0)
            {
                MessageBox.Show("Please select an expense to delete");
                return;
            }

            int idToDelete = selectedId; // ✅ store safely

            if (MessageBox.Show(
                "Delete this expense?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) != DialogResult.Yes)
                return;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Expenses WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = idToDelete;

                con.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Expense Deleted ❌");
            ClearFields();
            

            RefreshAllGrids();
        }




        private void LoadMonths()
        {
            cmbMonth.Items.Clear();
            cmbMonth.Items.Add("All");

            for (int i = 1; i <= 12; i++)
                cmbMonth.Items.Add(new DateTime(2024, i, 1).ToString("MMMM"));

            cmbMonth.SelectedIndex = 0;
        }
        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Load expenses into the report grid based on the selected month
            LoadReportData();

            // Update the category pie chart dynamically for the selected month or all history
            LoadCategoryChartForMonth();
        }

        void LoadReportData()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query =
                    cmbMonth.Text == "All"
                    ? "SELECT Id,[Date],[Description],Category,Amount FROM Expenses"
                    : "SELECT Id,[Date],[Description],Category,Amount FROM Expenses WHERE MONTH([Date])=@Month";

                SqlDataAdapter da = new SqlDataAdapter(query, con);

                if (cmbMonth.Text != "All")
                {
                    da.SelectCommand.Parameters.AddWithValue(
                        "@Month",
                        DateTime.ParseExact(cmbMonth.Text, "MMMM", null).Month);
                }

                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvReportExpenses.AutoGenerateColumns = true;
                dgvReportExpenses.DataSource = dt;
                dgvReportExpenses.Columns["Id"].Visible = false;
            }
        }




        void LoadCategoryChart()
        {
            chartCategory.Series.Clear();

            var series = chartCategory.Series.Add("Expenses");
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query =
                    "SELECT Category, SUM(Amount) Total FROM Expenses GROUP BY Category";

                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    series.Points.AddXY(dr["Category"], dr["Total"]);
                }
            }
        }
        

        void LoadCategoryChartForMonth()
        {
            chartCategory.Series.Clear();

            var series = chartCategory.Series.Add("Expenses");
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query;

                if (cmbMonth.Text == "All")
                {
                    query = "SELECT Category, SUM(Amount) Total FROM Expenses GROUP BY Category";
                }
                else
                {
                    int month = DateTime.ParseExact(cmbMonth.Text, "MMMM", null).Month;
                    query = "SELECT Category, SUM(Amount) Total FROM Expenses WHERE MONTH([Date])=@Month GROUP BY Category";
                }

                SqlCommand cmd = new SqlCommand(query, con);

                if (cmbMonth.Text != "All")
                    cmd.Parameters.AddWithValue("@Month", DateTime.ParseExact(cmbMonth.Text, "MMMM", null).Month);

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    series.Points.AddXY(dr["Category"], dr["Total"]);
                }
            }
        }





        private void lblThisMonthExpense_Click(object sender, EventArgs e)
        {

        }

        void LoadThisMonthExpense()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query =
                    "SELECT ISNULL(SUM(Amount),0) FROM Expenses " +
                    "WHERE [Date] >= DATEFROMPARTS(YEAR(GETDATE()), MONTH(GETDATE()), 1) " +
                    "AND [Date] < DATEADD(MONTH, 1, DATEFROMPARTS(YEAR(GETDATE()), MONTH(GETDATE()), 1))";

                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();

                decimal total = Convert.ToDecimal(cmd.ExecuteScalar());

                lblThisMonthExpense.Text = DateTime.Now.ToString("MMMM") + " Expense: Rs. " + total.ToString("N2");

            }
        }
        void LoadTopExpenseCategory()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query =
                    "SELECT TOP 1 Category, SUM(Amount) AS Total " +
                    "FROM Expenses " +
                    "WHERE [Date] >= DATEFROMPARTS(YEAR(GETDATE()), MONTH(GETDATE()), 1) " +
                    "AND [Date] < DATEADD(MONTH, 1, DATEFROMPARTS(YEAR(GETDATE()), MONTH(GETDATE()), 1)) " +
                    "GROUP BY Category " +
                    "ORDER BY Total DESC";

                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    lblTopCategory.Text = "Top Category:" + dr["Category"].ToString();
                }
                else
                {

                    lblTopCategory.Text = "No data";
                }
            }
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (selectedId == 0)
            {
                MessageBox.Show("Please select an expense to update");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "UPDATE Expenses SET [Date]=@Date, [Description]=@Desc, Category=@Cat, Amount=@Amt WHERE Id=@Id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Date", dtpExpenseDate.Value.Date);
                cmd.Parameters.AddWithValue("@Desc", txtDescription.Text);
                cmd.Parameters.AddWithValue("@Cat", cmbCategory.Text);
                cmd.Parameters.AddWithValue("@Amt", nudAmount.Value);
                cmd.Parameters.AddWithValue("@Id", selectedId);

                con.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Expense Updated ✅");
            ClearFields();
            RefreshAllGrids();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false; // Only one row at a time

        }

        void LoadNewestExpenses()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query =
                    "SELECT TOP 10 Id, [Date], [Description], Category, Amount " +
                    "FROM Expenses " +
                    "ORDER BY Id DESC";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvRecentExpenses.DataSource = dt;

                if (dgvRecentExpenses.Columns.Contains("Id"))
                    dgvRecentExpenses.Columns["Id"].Visible = false;

                dgvRecentExpenses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvRecentExpenses.MultiSelect = false;
            }
        }

        void RefreshAllGrids()
        {
            LoadRecentExpenses();     // dataGridView1
            LoadNewestExpenses();     // dgvRecentExpenses
            LoadReportData();         // dgvReportExpenses
            LoadTotalExpense();
            LoadCategoryChart();
            LoadThisMonthExpense();
            LoadTopExpenseCategory();
            LoadMonthComparisonChart();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (selectedId == 0)
            {
                MessageBox.Show("Please select an expense to delete");
                return;
            }

            int idToDelete = selectedId; // ✅ store safely

            if (MessageBox.Show(
                "Delete this expense?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) != DialogResult.Yes)
                return;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Expenses WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = idToDelete;

                con.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Expense Deleted ❌");
            ClearFields();
            RefreshAllGrids();
        }

        void LoadMonthComparisonChart()
        {
            chartMonthComparison.Series.Clear();
            chartMonthComparison.ChartAreas.Clear();

            ChartArea area = new ChartArea();
            area.AxisX.Title = "Day";
            area.AxisY.Title = "Amount (Rs)";
            chartMonthComparison.ChartAreas.Add(area);

            var thisMonthSeries = chartMonthComparison.Series.Add("This Month");
            thisMonthSeries.ChartType = SeriesChartType.Line;
            thisMonthSeries.BorderWidth = 3;
            thisMonthSeries.BorderDashStyle = ChartDashStyle.Solid;   // Smooth solid line
            thisMonthSeries.MarkerStyle = MarkerStyle.Circle;         // Circle points
            thisMonthSeries.MarkerSize = 7;
            thisMonthSeries.ToolTip = "Day #VALX : Rs #VALY";          // Tooltip

            var lastMonthSeries = chartMonthComparison.Series.Add("Last Month");
            lastMonthSeries.ChartType = SeriesChartType.Line;
            lastMonthSeries.BorderWidth = 3;
            lastMonthSeries.BorderDashStyle = ChartDashStyle.Dash;    // Dashed line
            lastMonthSeries.MarkerStyle = MarkerStyle.Square;         // Square points
            lastMonthSeries.MarkerSize = 7;
            lastMonthSeries.ToolTip = "Day #VALX : Rs #VALY";          // Tooltip

            dtThisMonth = new DataTable();
            dtLastMonth = new DataTable();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                // This Month Data
                new SqlDataAdapter(
                    @"SELECT DAY([Date]) Day, SUM(Amount) Total
              FROM Expenses
              WHERE YEAR([Date]) = YEAR(GETDATE())
              AND MONTH([Date]) = MONTH(GETDATE())
              GROUP BY DAY([Date])
              ORDER BY Day",
                    con).Fill(dtThisMonth);

                // Last Month Data
                new SqlDataAdapter(
                    @"SELECT DAY([Date]) Day, SUM(Amount) Total
              FROM Expenses
              WHERE [Date] >= DATEADD(MONTH, -1,
                    DATEFROMPARTS(YEAR(GETDATE()), MONTH(GETDATE()), 1))
              AND [Date] < DATEFROMPARTS(YEAR(GETDATE()), MONTH(GETDATE()), 1)
              GROUP BY DAY([Date])
              ORDER BY Day",
                    con).Fill(dtLastMonth);
            }

            animationIndex = 0;

            chartTimer = new Timer();
            chartTimer.Interval = 150; // speed (lower = faster)
            chartTimer.Tick += AnimateChart;
            chartTimer.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Load selected month data into dgvReportExpenses
            LoadReportData(); // this already uses cmbMonth selection

            Microsoft.Office.Interop.Excel.Application xlApp =
                new Microsoft.Office.Interop.Excel.Application();

            xlApp.Workbooks.Add();

            Microsoft.Office.Interop.Excel._Worksheet sheet = xlApp.ActiveSheet;

            // Export headers
            for (int i = 0; i < dgvReportExpenses.Columns.Count; i++)
                sheet.Cells[1, i + 1] = dgvReportExpenses.Columns[i].HeaderText;

            // Export rows
            for (int i = 0; i < dgvReportExpenses.Rows.Count; i++)
                for (int j = 0; j < dgvReportExpenses.Columns.Count; j++)
                    sheet.Cells[i + 2, j + 1] = dgvReportExpenses.Rows[i].Cells[j].Value;

            xlApp.Visible = true;

            // Update Category Chart dynamically for the selected month
            LoadCategoryChartForMonth();
        }

        void AnimateChart(object sender, EventArgs e)
        {
            if (animationIndex < dtThisMonth.Rows.Count)
            {
                chartMonthComparison.Series["This Month"]
                    .Points.AddXY(
                        dtThisMonth.Rows[animationIndex]["Day"],
                        dtThisMonth.Rows[animationIndex]["Total"]);
            }

            if (animationIndex < dtLastMonth.Rows.Count)
            {
                chartMonthComparison.Series["Last Month"]
                    .Points.AddXY(
                        dtLastMonth.Rows[animationIndex]["Day"],
                        dtLastMonth.Rows[animationIndex]["Total"]);
            }

            animationIndex++;

            if (animationIndex >= dtThisMonth.Rows.Count &&
                animationIndex >= dtLastMonth.Rows.Count)
            {
                chartTimer.Stop();
            }
        }


    }


}
