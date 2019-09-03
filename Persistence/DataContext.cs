using System;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<WeatherForcast> WeatherForcasts { get; set; }

        protected override void OnModelCreating(ModelBuilder builder){
            builder.Entity<WeatherForcast>()
                .HasData(
                    new WeatherForcast{
                        Id = 1,
                        Date = DateTime.Now,
                        TemperatureC = 30,
                        Summary = "It is warm out today"
                    },
                    new WeatherForcast{
                        Id = 2,
                        Date = DateTime.Now.AddDays(-1),
                        TemperatureC = 20,
                        Summary = "It is cold out today"
                    },
                    new WeatherForcast{
                        Id = 3,
                        Date = DateTime.Now.AddDays(-2),
                        TemperatureC = 45,
                        Summary = "It is HOT out today"
                    }
                );
        }
    }
}
