using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WeatherAPI;

[ApiController]
[Route("api/[controller]")]
public class WeatherController
{
    private readonly WeatherContext _context;
    public WeatherController(WeatherContext weatherContext)
    {
        _context = weatherContext;
    }
    
    [HttpGet]
    public async Task<IEnumerable<Weather>> Get()
    {
        var result =  await _context.WeatherData.ToListAsync();
        
        if (result.Count == 0)
        {
            Console.WriteLine("No weather data found!");
        }

        return result;
    }
    
    [HttpPost]
    public async void Create(string location, string temperature)
    {
        await _context.AddAsync(new Weather() {location = location, temperature = temperature });
        _context.SaveChanges();
    }
}