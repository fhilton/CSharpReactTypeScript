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
            new WeatherForecast { Id = 2, Date = DateTime.Now.AddDays(2), TemperatureC = 20, Summary = "Warm" }
            // Add more seed data as required
        );
    }

}
