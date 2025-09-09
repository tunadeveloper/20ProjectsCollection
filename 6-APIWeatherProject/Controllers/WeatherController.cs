using _6_APIWeatherProject.Context;
using _6_APIWeatherProject.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _6_APIWeatherProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherController : ControllerBase
    {
        private readonly WeatherContext _weatherContext;

        public WeatherController(WeatherContext weatherContext)
        {
            _weatherContext = weatherContext;
        }

        [HttpGet("List")]
        public IActionResult WeatherCityList()
        {
            var values = _weatherContext.Cities.ToList();
            return Ok(values);
        }

        [HttpPost("Create")]
        public IActionResult CreateWeatherCity(City city)
        {
            _weatherContext.Cities.Add(city);
            _weatherContext.SaveChanges();
            return Ok("Şehir Bilgisi Eklendi!");
        }

        [HttpDelete("Delete")]
        public IActionResult DeleteWeatherCity(int cityId)
        {
            var values = _weatherContext.Cities.Find(cityId);
            _weatherContext.Cities.Remove(values);
            _weatherContext.SaveChanges();
            return Ok("Şehir Bilgisi Silindi!");
        }

        [HttpPut("Update")]
        public IActionResult UpdateWeatherCity(City city)
        {
            var values = _weatherContext.Cities.Find(city.CityId);
            values.CityName = city.CityName;
            values.Detail = city.Detail;
            values.Temp = city.Temp;
            values.CountryName = city.CountryName;  
            _weatherContext.SaveChanges();
            return Ok("Şehir Bilgisi Güncellendi!");
        }

        [HttpGet("GetById")]
        public IActionResult GetByIdWeatherCity(int cityId)
        {
            var values = _weatherContext.Cities.Find(cityId);
            return Ok(values);
        }

        [HttpGet("TotalCityCount")]
        public IActionResult TotalCityCount()
        {
            var values = _weatherContext.Cities.Count();
            return Ok(values);
        }

        [HttpGet("MaxTempCityName")]
        public IActionResult MaxTempCityName()
        {
            var values = _weatherContext.Cities.OrderByDescending(x=>x.Temp).Select(x=>x.CityName).FirstOrDefault();
            return Ok(values);
        }

        [HttpGet("MinTempCityName")]
        public IActionResult MinTempCityName()
        {
            var values = _weatherContext.Cities.OrderBy(x => x.Temp).Select(x => x.CityName).FirstOrDefault();
            return Ok(values);
        }
    }
}
