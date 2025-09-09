using _6_APIWeatherProject.Entities;
using Microsoft.EntityFrameworkCore;

namespace _6_APIWeatherProject.Context
{
    public class WeatherContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=TUNA\\SQLEXPRESS;initial catalog=DbAPIWeatherProject;integrated security=true");
        }

        public DbSet<City> Cities { get; set; }
    }
}
