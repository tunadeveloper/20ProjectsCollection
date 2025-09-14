using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.Globalization;

namespace _15_RapidAPIGasPriceSimulationProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double dieselPrice = 0;
        double gasolinePrice = 0;
        double lpgPrice = 0;
        double gasAmount = 0;
        double dieselAmount = 0;
        double lpgAmount = 0;
        double totalPrice = 0;
        int count = 0;

        private void btnStart_Click(object sender, EventArgs e)
        {
            double amount = 0;
            double pricePerLitre = 0;

            if (rdbGasoline.Checked)
            {
                amount = Convert.ToDouble(txtFuelAmount.Text);
                pricePerLitre = gasolinePrice;
            }
            else if (rdbDiesel.Checked)
            {
                amount = Convert.ToDouble(txtFuelAmount.Text);
                pricePerLitre = dieselPrice;
            }
            else if (rdbLpg.Checked)
            {
                amount = Convert.ToDouble(txtFuelAmount.Text);
                pricePerLitre = lpgPrice;
            }

            totalPrice = amount * pricePerLitre;

            progressBar1.Value = 0;
            timer1.Interval = 10;
            int steps = 100;
            double stepValue = totalPrice / steps;

            int currentStep = 0;
            timer1.Tick += (s, ev) =>
            {
                if (currentStep < steps)
                {
                    txtTotalPrice.Text = ((currentStep + 1) * stepValue).ToString("0.00") + " ₺";
                    progressBar1.Value = currentStep + 1;
                    currentStep++;
                }
                else
                {
                    timer1.Stop();
                }
            };

            timer1.Start();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (rdbGasoline.Checked)
            {
                if (count < gasAmount)
                {
                    totalPrice += gasolinePrice;
                    count++;
                    txtTotalPrice.Text = totalPrice.ToString("0.00") + " ₺";
                    progressBar1.Value = Math.Min((int)(count / gasAmount * 100), 100);
                }
                else
                {
                    timer1.Stop();
                }
            }
            else if (rdbDiesel.Checked)
            {
                if (count < dieselAmount)
                {
                    totalPrice += dieselPrice;
                    count++;
                    txtTotalPrice.Text = totalPrice.ToString("0.00") + " ₺";
                    progressBar1.Value = Math.Min((int)(count / dieselAmount * 100), 100);
                }
                else
                {
                    timer1.Stop();
                }
            }
            else if (rdbLpg.Checked)
            {
                if (count < lpgAmount)
                {
                    totalPrice += lpgPrice;
                    count++;
                    txtTotalPrice.Text = totalPrice.ToString("0.00") + " ₺";
                    progressBar1.Value = Math.Min((int)(count / lpgAmount * 100), 100);
                }
                else
                {
                    timer1.Stop();
                }
            }
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("https://gas-price.p.rapidapi.com/canada"),
                    Headers =
            {
                { "x-rapidapi-key", "e71177d867mshfa37763bf5e2e10p1b4212jsn34b1dc08d068" },
                { "x-rapidapi-host", "gas-price.p.rapidapi.com" },
            },
                };

                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();
                    var json = JObject.Parse(body);

                    var calgary = json["result"][0]["cities"][0];
                    double gasolineCad = double.Parse(calgary["gasoline"].ToString(), CultureInfo.InvariantCulture);

                    double cadToTry = 20;
                    gasolinePrice = gasolineCad * cadToTry;
                    dieselPrice = gasolinePrice * 0.9;
                    lpgPrice = gasolinePrice * 0.5;

                    txtGasolinePrice.Text = gasolinePrice.ToString("0.00") + " ₺";
                    txtDieselPrice.Text = dieselPrice.ToString("0.00") + " ₺";
                    txtLpgPrice.Text = lpgPrice.ToString("0.00") + " ₺";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fiyatları alırken hata oluştu: " + ex.Message);
            }
        }
    }
}
