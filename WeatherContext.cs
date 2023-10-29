using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;

namespace WeatherAPI;

public class WeatherContext: DbContext
{
    public WeatherContext(DbContextOptions<WeatherContext> options): base(options)
    {
    }

    public DbSet<Weather> WeatherData { get; set; } = null;
}