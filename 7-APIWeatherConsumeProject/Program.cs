#region menu_start

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text;
using System.Text.Json.Nodes;

Console.WriteLine("Api Consume Projesi");
Console.WriteLine();
Console.WriteLine("### Yapmak İstediğiniz İşlemi Seçin ###");
Console.WriteLine();
Console.WriteLine("1-) Şehir Listesini Getir");
Console.WriteLine("2-) Şehir Ve Hava Durumu Getir");
Console.WriteLine("3-) Yeni Şehir Ekle");
Console.WriteLine("4-) Şehir Sil");
Console.WriteLine("5-) Şehir Güncelle");
Console.WriteLine("6-) ID'ye Göre Şehir Getir");
Console.WriteLine();

#endregion

string number;

Console.Write("İşlem: ");
number = Console.ReadLine();
HttpClient client = new HttpClient();
switch (number)
{
    case "1":
        {
            try
            {
                string url = "https://localhost:7023/api/Weather/List";
                HttpResponseMessage response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    JArray jArray = JArray.Parse(responseBody);

                    foreach (var item in jArray)
                    {
                        string cityName = item["cityName"].ToString();
                        Console.WriteLine($"Şehir: {cityName}");
                    }
                }
                else
                {
                    Console.WriteLine("❌ Şehir listesi alınamadı!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Hata: {ex.Message}");
            }
            break;
        }

    case "2":
        {
            try
            {
                string url = "https://localhost:7023/api/Weather/List";
                HttpResponseMessage response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    JArray jArray = JArray.Parse(responseBody);
                    foreach (var item in jArray)
                    {
                        string cityName = item["cityName"].ToString();
                        string temp = item["temp"].ToString();
                        string country = item["countryName"].ToString();
                        Console.WriteLine($"{cityName} - {country} --> {temp} Derece ");
                        Console.WriteLine("-----------------------------------");
                    }
                }
                else
                {
                    Console.WriteLine("❌ Şehir ve hava durumu bilgisi alınamadı!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Hata: {ex.Message}");
            }
            break;
        }

    case "3":
        {
            try
            {
                Console.Write("Şehir Adı: ");
                string cityName = Console.ReadLine();

                Console.Write("Ülke Adı: ");
                string countryName = Console.ReadLine();

                Console.Write("Hava Durumu Detayı: ");
                string detail = Console.ReadLine();

                Console.Write("Sıcaklık: ");
                if (!decimal.TryParse(Console.ReadLine(), out decimal temp))
                {
                    Console.WriteLine("❌ Geçerli bir sıcaklık değeri giriniz!");
                    break;
                }

                string url = "https://localhost:7023/api/Weather/Create";
                var newWeatherCity = new
                {
                    CityName = cityName,
                    CountryName = countryName,
                    Detail = detail,
                    Temp = temp
                };

                string json = JsonConvert.SerializeObject(newWeatherCity);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync(url, content);

                if (response.IsSuccessStatusCode)
                    Console.WriteLine("✅ Şehir başarıyla eklendi!");
                else
                    Console.WriteLine("❌ Şehir eklenemedi!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Hata: {ex.Message}");
            }
            break;
        }

    case "4":
        {
            try
            {
                string url = "https://localhost:7023/api/Weather/Delete?cityId=";
                Console.Write("Silinecek Verinin ID'si: ");
                int id = int.Parse(Console.ReadLine());

                HttpResponseMessage response = await client.DeleteAsync(url + id);

                if (response.IsSuccessStatusCode)
                    Console.WriteLine("✅ Şehir başarıyla silindi!");
                else
                    Console.WriteLine("❌ Şehir silinemedi!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Hata: {ex.Message}");
            }
            break;
        }

    case "5":
        {
            try
            {
                Console.Write("Şehir Adı: ");
                string cityName = Console.ReadLine();

                Console.Write("Ülke Adı: ");
                string countryName = Console.ReadLine();

                Console.Write("Hava Durumu Detayı: ");
                string detail = Console.ReadLine();

                Console.Write("Sıcaklık: ");
                if (!decimal.TryParse(Console.ReadLine(), out decimal temp))
                {
                    Console.WriteLine("❌ Geçerli bir sıcaklık değeri giriniz!");
                    break;
                }

                Console.Write("Şehir Id: ");
                int cityId = int.Parse(Console.ReadLine());

                string url = "https://localhost:7023/api/Weather/Update";
                var updatedWeatherValues = new
                {
                    CityId = cityId,
                    CountryName = countryName,
                    Detail = detail,
                    CityName = cityName,
                    Temp = temp
                };

                string json = JsonConvert.SerializeObject(updatedWeatherValues);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PutAsync(url, content);

                if (response.IsSuccessStatusCode)
                    Console.WriteLine("✅ Şehir başarıyla güncellendi!");
                else
                    Console.WriteLine("❌ Şehir güncellenemedi!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Hata: {ex.Message}");
            }
            break;
        }

    case "6":
        {
            try
            {
                string url = "https://localhost:7023/api/Weather/GetById?cityId=";

                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());

                HttpResponseMessage response = await client.GetAsync(url + id);

                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    JObject weatherCityObject = JObject.Parse(responseBody);

                    string cityName = weatherCityObject["cityName"]?.ToString();
                    string detail = weatherCityObject["detail"]?.ToString();
                    string country = weatherCityObject["countryName"]?.ToString();
                    string temp = weatherCityObject["temp"]?.ToString();

                    Console.WriteLine($"Şehir: {cityName}");
                    Console.WriteLine($"Ülke: {country}");
                    Console.WriteLine($"Detay: {detail}");
                    Console.WriteLine($"Sıcaklık: {temp}");
                }
                else
                {
                    Console.WriteLine("❌ İstenen şehir bulunamadı!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Hata: {ex.Message}");
            }
            break;
        }
}

Console.Read();