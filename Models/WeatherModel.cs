using System.ComponentModel.DataAnnotations;

namespace aspnet_core_demo.Models;

public class WeatherModel
{
    [Display(Name = "City Name")]
    public string CityName { get; set; }

    public WeatherResultModel Result { get; set; }
}