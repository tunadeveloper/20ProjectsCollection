using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace _19_RestaurantTableCurrentStatusProject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            using (var context = new TableCurrentStatusDbEntities())
            {
                var buttons = panelMasalar.Controls.OfType<Button>().ToList();
                foreach (var btn in buttons)
                {
                    panelMasalar.Controls.Remove(btn);
                    btn.Dispose();
                }

                var values = context.Tables.ToList();
                int buttonSize = 90;
                int padding = 30;
                int xOffset = 20;
                int yOffset = 20;

                ToolTip tt = new ToolTip();

                for (int i = 0; i < values.Count; i++)
                {
                    var item = values[i];
                    Button button = new Button();
                    button.Text = item.TableNumber;
                    button.Size = new Size(buttonSize, buttonSize);
                    button.Location = new Point(
                        xOffset + (i % 5) * (buttonSize + padding),
                        yOffset + (i / 5) * (buttonSize + padding));

                    button.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                    button.ForeColor = Color.White;
                    button.FlatStyle = FlatStyle.Flat;
                    button.FlatAppearance.BorderSize = 0;

                    System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
                    path.AddEllipse(0, 0, button.Width, button.Height);
                    button.Region = new Region(path);

                    if (item.Status.GetValueOrDefault())
                    {
                        button.BackColor = Color.FromArgb(0, 180, 120);
                        tt.SetToolTip(button, "Masa boş");
                    }
                    else
                    {
                        button.BackColor = Color.FromArgb(200, 60, 80);
                        tt.SetToolTip(button, "Masa dolu");
                    }

                    button.MouseEnter += (s, ev) =>
                    {
                        button.BackColor = ControlPaint.Light(button.BackColor, 0.25f);
                    };
                    button.MouseLeave += (s, ev) =>
                    {
                        button.BackColor = item.Status.GetValueOrDefault()
                            ? Color.FromArgb(0, 180, 120)
                            : Color.FromArgb(200, 60, 80);
                    };

                    button.Click += (s, ev) =>
                    {
                        MessageBox.Show($"Seçilen {button.Text} durumu: " +
                            (item.Status.GetValueOrDefault() ? "Boş" : "Dolu"));
                    };

                    panelMasalar.Controls.Add(button);
                }
            }
        }

    }
}
