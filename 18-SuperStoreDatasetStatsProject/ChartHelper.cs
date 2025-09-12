using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace _18_SuperStoreDatasetStatsProject
{
    public static class ChartHelper
    {
        public static void SetupBarChart(Chart chart)
        {
            chart.BackColor = Color.Transparent;
            chart.ChartAreas.Clear();
            chart.Series.Clear();

            ChartArea area = new ChartArea("MainArea");
            area.BackColor = Color.Transparent;
            area.AxisX.LineColor = Color.White;
            area.AxisY.LineColor = Color.White;
            area.AxisX.LabelStyle.ForeColor = Color.White;
            area.AxisY.LabelStyle.ForeColor = Color.White;
            area.AxisX.TitleForeColor = Color.White;
            area.AxisY.TitleForeColor = Color.White;
            area.AxisX.MajorGrid.Enabled = false;
            area.AxisY.MajorGrid.Enabled = false;

            chart.ChartAreas.Add(area);

            Series series = new Series("Series1");
            series.ChartType = SeriesChartType.Column;
            series.Color = Color.FromArgb(33, 150, 243);
            series.BorderWidth = 2;
            series.IsValueShownAsLabel = true;
            series.LabelForeColor = Color.White;

            chart.Series.Add(series);
        }

        public static void SetupPieChart(Chart chart)
        {
            chart.BackColor = Color.Transparent;
            chart.ChartAreas.Clear();
            chart.Series.Clear();

            ChartArea area = new ChartArea("MainArea");
            area.BackColor = Color.Transparent;
            chart.ChartAreas.Add(area);

            Series series = new Series("PieChart");
            series.ChartType = SeriesChartType.Pie;
            series.IsValueShownAsLabel = true;
            series.LabelForeColor = Color.White;
            series.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            chart.Series.Add(series);
        }

        public static void SetupLineChart(Chart chart)
        {
            chart.BackColor = Color.Transparent;
            chart.ChartAreas.Clear();
            chart.Series.Clear();

            ChartArea area = new ChartArea("MainArea");
            area.BackColor = Color.Transparent;
            area.AxisX.LineColor = Color.White;
            area.AxisY.LineColor = Color.White;
            area.AxisX.LabelStyle.ForeColor = Color.White;
            area.AxisY.LabelStyle.ForeColor = Color.White;
            area.AxisX.TitleForeColor = Color.White;
            area.AxisY.TitleForeColor = Color.White;
            area.AxisX.MajorGrid.Enabled = false;
            area.AxisY.MajorGrid.Enabled = false;

            chart.ChartAreas.Add(area);

            Series series = new Series("Trend");
            series.ChartType = SeriesChartType.Line;
            series.Color = Color.FromArgb(76, 175, 80);
            series.BorderWidth = 3;
            series.MarkerStyle = MarkerStyle.Circle;
            series.MarkerSize = 8;
            series.MarkerColor = Color.FromArgb(76, 175, 80);
            series.IsValueShownAsLabel = true;
            series.LabelForeColor = Color.White;

            chart.Series.Add(series);
        }
    }
}
