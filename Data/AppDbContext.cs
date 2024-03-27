namespace CSharpReactTypeScript.Data;

using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    
    public DbSet<WeatherForecast> WeatherForecasts { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=weatherapp.db");
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<WeatherForecast>().HasData(
            new WeatherForecast { Id = 1, Date = DateTime.Now.AddDays(1), TemperatureC = 25, Summary = "Hot" },
            new WeatherForecast { Id = 2, Date = DateTime.Now.AddDays(2), TemperatureC = 20, Summary = "Warm" },
            new WeatherForecast { Id = 3, Date = DateTime.Now.AddDays(3), TemperatureC = 15, Summary = "Mild" },
            new WeatherForecast { Id = 4, Date = DateTime.Now.AddDays(4), TemperatureC = 10, Summary = "Cool" },
            new WeatherForecast { Id = 5, Date = DateTime.Now.AddDays(5), TemperatureC = 5, Summary = "Chilly" },
            new WeatherForecast { Id = 6, Date = DateTime.Now.AddDays(6), TemperatureC = 0, Summary = "Cold" },
            new WeatherForecast { Id = 7, Date = DateTime.Now.AddDays(7), TemperatureC = -5, Summary = "Freezing" },
            new WeatherForecast { Id = 8, Date = DateTime.Now.AddDays(8), TemperatureC = 30, Summary = "Scorching" },
            new WeatherForecast { Id = 9, Date = DateTime.Now.AddDays(9), TemperatureC = 35, Summary = "Sweltering" },
            new WeatherForecast { Id = 10, Date = DateTime.Now.AddDays(10), TemperatureC = -10, Summary = "Frigid" },
            new WeatherForecast { Id = 11, Date = DateTime.Now.AddDays(11), TemperatureC = 40, Summary = "Blazing" },
            new WeatherForecast { Id = 12, Date = DateTime.Now.AddDays(12), TemperatureC = 22, Summary = "Pleasant" }
        );
    }


}
