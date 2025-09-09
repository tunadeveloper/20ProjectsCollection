namespace _6_APIWeatherProject.Entities
{
    public class City
    {
        public int CityId { get; set; }
        public string CityName { get; set; }
        public string CountryName { get; set; }
        public decimal Temp { get; set; }
        public string Detail { get; set; }
    }
}
