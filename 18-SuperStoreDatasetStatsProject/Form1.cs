using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace _18_SuperStoreDatasetStatsProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            FormDesignHelper.SetupForm(
                this,
                new GroupBox[] { grpStatsCards, grpBarChart, grpPieChart, grpLineChart },
                new Panel[] { pnlCard1, pnlCard2, pnlCard3, pnlCard4 }
            );

            ChartHelper.SetupBarChart(chartBar);
            ChartHelper.SetupPieChart(chartPie);
            ChartHelper.SetupLineChart(chartLine);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadWidgetsData();
            LoadBarChartData();
            LoadPieChartData();
            LoadLineChartData();
        }


        SqlConnection connection = new SqlConnection("Server=TUNA\\SQLEXPRESS;initial catalog=KaggleDatasetDB;integrated security=true");

        private void LoadPieChartData()
        {
            chartPie.Series["PieChart"].Points.Clear();

            connection.Open();
            SqlCommand cmd = new SqlCommand(@"
        SELECT TOP(4) Country, SUM(Quantity) 
        FROM superstore 
        GROUP BY Country 
        ORDER BY SUM(Quantity) DESC", connection);

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var p = chartPie.Series["PieChart"].Points.AddXY(reader[0], reader[1]);
                chartPie.Series["PieChart"].Points[p].Label = reader[0].ToString();
            }
            connection.Close();
        }

        private void LoadLineChartData()
        {
            chartLine.Series["Trend"].Points.Clear();

            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT Order_Priority, COunt(*) From superstore Group By Order_Priority Order BY Order_Priority DESC", connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                chartLine.Series["Trend"].Points.AddXY(reader[0], reader[1]);
            }
            connection.Close();
        }

        private void LoadBarChartData()
        {
            chartBar.Series["Series1"].Points.Clear();

            connection.Open();
            SqlCommand cmd = new SqlCommand(@"
        SELECT TOP(6) Country, COUNT(*) 
        FROM superstore 
        GROUP BY Country 
        ORDER BY COUNT(*) DESC", connection);

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                chartBar.Series["Series1"].Points.AddXY(reader[0], reader[1]);
            }
            connection.Close();
        }

        private void LoadWidgetsData()
        {
            connection.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT COUNT(*) FROM superstore", connection);
            lblProductValue.Text = cmd1.ExecuteScalar().ToString();
            connection.Close();

            connection.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT COUNT(DISTINCT(State)) FROM superstore", connection);
            lblCityValue.Text = cmd2.ExecuteScalar().ToString();
            connection.Close();

            connection.Open();
            SqlCommand cmd3 = new SqlCommand("SELECT COUNT(*) FROM superstore WHERE Country='Turkey'", connection);
            lblTurkeyValue.Text = cmd3.ExecuteScalar().ToString();
            connection.Close();

            connection.Open();
            SqlCommand cmd4 = new SqlCommand("SELECT SUM(Quantity) FROM superstore", connection);
            lblOrderValue.Text = cmd4.ExecuteScalar().ToString();
            connection.Close();
        }


      
    }
}
