using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cms
{
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
            SetupCharts();
        }

        private void SetupCharts()
        {
            SetupWeeklyChart();
            SetupMonthlyChart();
        }

        private void SetupWeeklyChart()
        {
            // Clear existing controls if any
            if (weeklySale != null && weeklySale.Controls.Count > 0)
            {
                weeklySale.Controls.Clear();
            }

            // Create a TableLayoutPanel for weekly sales display
            TableLayoutPanel weeklyPanel = new TableLayoutPanel();
            weeklyPanel.Dock = DockStyle.Fill;
            weeklyPanel.BackColor = Color.White;
            weeklyPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

            // Add days as rows
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            int[] sales = { 12500, 18700, 15400, 21000, 28500, 32000, 27500 };

            weeklyPanel.RowCount = days.Length + 1;
            weeklyPanel.ColumnCount = 2;

            // Add headers
            Label header1 = new Label();
            header1.Text = "Day";
            header1.Font = new Font("Arial", 10, FontStyle.Bold);
            header1.TextAlign = ContentAlignment.MiddleCenter;
            header1.BackColor = Color.FromArgb(40, 41, 34);
            header1.ForeColor = Color.White;
            weeklyPanel.Controls.Add(header1, 0, 0);

            Label header2 = new Label();
            header2.Text = "Sales (₱)";
            header2.Font = new Font("Arial", 10, FontStyle.Bold);
            header2.TextAlign = ContentAlignment.MiddleCenter;
            header2.BackColor = Color.FromArgb(40, 41, 34);
            header2.ForeColor = Color.White;
            weeklyPanel.Controls.Add(header2, 1, 0);

            // Add data rows
            for (int i = 0; i < days.Length; i++)
            {
                Label dayLabel = new Label();
                dayLabel.Text = days[i];
                dayLabel.Font = new Font("Arial", 9);
                dayLabel.TextAlign = ContentAlignment.MiddleLeft;
                dayLabel.Padding = new Padding(5, 0, 0, 0);
                weeklyPanel.Controls.Add(dayLabel, 0, i + 1);

                Label salesLabel = new Label();
                salesLabel.Text = $"₱{sales[i]:#,##0}";
                salesLabel.Font = new Font("Arial", 9, FontStyle.Bold);
                salesLabel.TextAlign = ContentAlignment.MiddleRight;
                salesLabel.Padding = new Padding(0, 0, 5, 0);
                weeklyPanel.Controls.Add(salesLabel, 1, i + 1);
            }

            // Add title
            Label weeklyTitle = new Label();
            weeklyTitle.Text = "Weekly Sales Report";
            weeklyTitle.Font = new Font("Arial", 12, FontStyle.Bold);
            weeklyTitle.TextAlign = ContentAlignment.MiddleCenter;
            weeklyTitle.Dock = DockStyle.Top;
            weeklyTitle.Height = 30;
            weeklyTitle.BackColor = Color.FromArgb(40, 41, 34);
            weeklyTitle.ForeColor = Color.FromArgb(228, 186, 94);

            weeklySale.Controls.Add(weeklyTitle);
            weeklySale.Controls.Add(weeklyPanel);
            weeklyPanel.Dock = DockStyle.Fill;
        }

        private void SetupMonthlyChart()
        {
            // Clear existing controls if any
            if (monthlySale != null && monthlySale.Controls.Count > 0)
            {
                monthlySale.Controls.Clear();
            }

            // Create a TableLayoutPanel for monthly sales display
            TableLayoutPanel monthlyPanel = new TableLayoutPanel();
            monthlyPanel.Dock = DockStyle.Fill;
            monthlyPanel.BackColor = Color.White;
            monthlyPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

            // Add months as rows
            string[] months = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
            int[] monthlySales = { 125000, 187000, 154000, 210000, 285000, 320000, 295000, 350000, 310000, 380000, 420000, 500000 };

            monthlyPanel.RowCount = months.Length + 1;
            monthlyPanel.ColumnCount = 2;

            // Add headers
            Label header1 = new Label();
            header1.Text = "Month";
            header1.Font = new Font("Arial", 10, FontStyle.Bold);
            header1.TextAlign = ContentAlignment.MiddleCenter;
            header1.BackColor = Color.FromArgb(228, 186, 94);
            header1.ForeColor = Color.FromArgb(40, 41, 34);
            monthlyPanel.Controls.Add(header1, 0, 0);

            Label header2 = new Label();
            header2.Text = "Sales (₱)";
            header2.Font = new Font("Arial", 10, FontStyle.Bold);
            header2.TextAlign = ContentAlignment.MiddleCenter;
            header2.BackColor = Color.FromArgb(228, 186, 94);
            header2.ForeColor = Color.FromArgb(40, 41, 34);
            monthlyPanel.Controls.Add(header2, 1, 0);

            // Add data rows
            for (int i = 0; i < months.Length; i++)
            {
                Label monthLabel = new Label();
                monthLabel.Text = months[i];
                monthLabel.Font = new Font("Arial", 9);
                monthLabel.TextAlign = ContentAlignment.MiddleLeft;
                monthLabel.Padding = new Padding(5, 0, 0, 0);
                monthlyPanel.Controls.Add(monthLabel, 0, i + 1);

                Label salesLabel = new Label();
                salesLabel.Text = $"₱{monthlySales[i]:#,##0}";
                salesLabel.Font = new Font("Arial", 9, FontStyle.Bold);
                salesLabel.TextAlign = ContentAlignment.MiddleRight;
                salesLabel.Padding = new Padding(0, 0, 5, 0);
                monthlyPanel.Controls.Add(salesLabel, 1, i + 1);
            }

            // Add title
            Label monthlyTitle = new Label();
            monthlyTitle.Text = "Monthly Sales Report";
            monthlyTitle.Font = new Font("Arial", 12, FontStyle.Bold);
            monthlyTitle.TextAlign = ContentAlignment.MiddleCenter;
            monthlyTitle.Dock = DockStyle.Top;
            monthlyTitle.Height = 30;
            monthlyTitle.BackColor = Color.FromArgb(228, 186, 94);
            monthlyTitle.ForeColor = Color.FromArgb(40, 41, 34);

            monthlySale.Controls.Add(monthlyTitle);
            monthlySale.Controls.Add(monthlyPanel);
            monthlyPanel.Dock = DockStyle.Fill;
        }

        private void weeklySale_Click(object sender, EventArgs e)
        {
            SetupCharts();
            MessageBox.Show("Charts refreshed!", "Dashboard", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void panel12_Click(object sender, EventArgs e)
        {
            // Refresh Data button clicked
            SetupCharts();
            MessageBox.Show("Data refreshed successfully!", "Dashboard", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void panel11_Click(object sender, EventArgs e)
        {
            // Generate Report button clicked
            MessageBox.Show("Report generation feature coming soon!", "Dashboard", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}