using CSharpReactTypeScript.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CSharpReactTypeScript.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly ILogger<WeatherForecastController> _logger;
    private readonly AppDbContext _context;

    public WeatherForecastController(AppDbContext context,ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
        _context = context;
    }

    [HttpGet]
    public async Task<IEnumerable<WeatherForecast>> Get()
    {
        return await _context.WeatherForecasts.ToListAsync();
    }
}
