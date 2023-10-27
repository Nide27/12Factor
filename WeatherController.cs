using Microsoft.AspNetCore.Mvc;

namespace WeatherAPI;

[ApiController]
[Route("api/[controller]")]
public class WeatherController
{
    [HttpGet]
    public Dictionary<string, string> Get(IConfiguration configuration)
    {
        Console.Write(configuration.GetValue<Dictionary<string, string>>("Weather"));

        var weather = configuration.GetSection("Weather").Get<Dictionary<string, string>>();
        
        if (weather.Count == 0)
        {
            Console.Write("No Weather data found");
        }
        return weather;
    }
}