using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SiF_AppData_API.Controllers;

[Authorize]
[ApiController]
[Route("[controller]")]
public class WeatherForecast1Controller : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecast1Controller> _logger;

    public WeatherForecast1Controller(ILogger<WeatherForecast1Controller> logger)
    {
        _logger = logger;
        var tmp = User;
    }

    [HttpGet(Name = "GetWeatherForecast1")]
    public IEnumerable<WeatherForecast> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }
}