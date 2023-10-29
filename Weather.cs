using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WeatherAPI;

[Table("weather")]
public class Weather
{
    [Key]
    [Column("id")]
    public int id { get; set; }

    [Column("location")]
    public string location { get; set; }
   
    [Column("temperature")]
    public string temperature { get; set; }
}