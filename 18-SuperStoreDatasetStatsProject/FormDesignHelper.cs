using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18_SuperStoreDatasetStatsProject
{
    public static class FormDesignHelper
    {
        public static void SetupForm(Form form, GroupBox[] groupBoxes, Panel[] panels)
        {
            form.Paint += (sender, e) => Form_Paint(form, e);

            foreach (var pnl in panels)
                MakeRoundedPanel(pnl);

            foreach (var grp in groupBoxes)
                grp.Paint += GroupBox_Paint;
        }

        private static void Form_Paint(Form form, PaintEventArgs e)
        {
            Rectangle rect = new Rectangle(0, 0, form.Width, form.Height);
            using (LinearGradientBrush brush = new LinearGradientBrush(
                rect,
                Color.FromArgb(30, 30, 30),
                Color.FromArgb(50, 50, 70),
                LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(brush, rect);
            }
        }

        private static void GroupBox_Paint(object sender, PaintEventArgs e)
        {
            if (sender is GroupBox groupBox)
            {
                e.Graphics.Clear(Color.Transparent);

                using (Pen pen = new Pen(Color.FromArgb(100, 255, 255, 255), 2))
                {
                    e.Graphics.DrawLine(pen, 0, groupBox.Font.Height + 5, groupBox.Width, groupBox.Font.Height + 5);
                }
            }
        }

        private static void MakeRoundedPanel(Panel panel)
        {
            panel.Paint += (sender, e) =>
            {
                if (sender is Panel pnl)
                {
                    GraphicsPath path = new GraphicsPath();
                    int radius = 15;
                    path.AddArc(0, 0, radius, radius, 180, 90);
                    path.AddArc(pnl.Width - radius, 0, radius, radius, 270, 90);
                    path.AddArc(pnl.Width - radius, pnl.Height - radius, radius, radius, 0, 90);
                    path.AddArc(0, pnl.Height - radius, radius, radius, 90, 90);
                    path.CloseAllFigures();

                    pnl.Region = new Region(path);

                    using (Pen shadowPen = new Pen(Color.FromArgb(50, 0, 0, 0), 3))
                    {
                        e.Graphics.DrawPath(shadowPen, path);
                    }
                }
            };
        }
    }
}
