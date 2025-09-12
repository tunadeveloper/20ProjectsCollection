using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13_RapidAPIWeatherProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://open-weather13.p.rapidapi.com/city/Istanbul/TR"),
                Headers =
    {
        { "x-rapidapi-key", "e71177d867mshfa37763bf5e2e10p1b4212jsn34b1dc08d068" },
        { "x-rapidapi-host", "open-weather13.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var json = JObject.Parse(body);

                var fahrenheit = json["main"]["feels_like"].ToString();
                var windSpeed = json["wind"]["speed"].ToString();
                var humidity = json["main"]["humidity"].ToString();
                var condition = json["weather"][0]["main"].ToString();

                lblFahrenheitValue.Text = fahrenheit;
                lblWindValue.Text = windSpeed;
                lblHumidityValue.Text = humidity;
                lblTemperature.Text = ((double.Parse(fahrenheit) - 32) /1.8).ToString("00.00°");

                switch (condition)
                {
                    case "Rain":
                        lblWeatherEmoji.Text = "🌧️";
                        break;
                    case "Clouds":
                        lblWeatherEmoji.Text = "☁️";
                        break;
                    case "Clear":
                        lblWeatherEmoji.Text = "☀️";
                        break;
                    case "Snow":
                        lblWeatherEmoji.Text = "❄️";
                        break;
                    default:
                        lblWeatherEmoji.Text = "🌡️";
                        break;
                }
            }
        }
    }
}
