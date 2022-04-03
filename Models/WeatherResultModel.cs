using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace aspnet_core_demo.Models;

public class WeatherResultModel
{
    [JsonPropertyName("location")]
    [Display(Name = "Location: ")]
    public Location Location { get; set; }

    [JsonPropertyName("current")]
    [Display(Name = "Location: ")]
    public Current Current { get; set; }
}

public class Current
{
    [JsonPropertyName("last_updated")]
    [Display(Name = "Location: ")]
    public string LastUpdated { get; set; }

    [JsonPropertyName("temp_c")]
    [Display(Name = "Location: ")]
    public double TempC { get; set; }

    [JsonPropertyName("temp_f")]
    [Display(Name = "Location: ")]
    public double TempF { get; set; }



    [JsonPropertyName("condition")]
    [Display(Name = "Condition: ")]
    public Condition Condition { get; set; }

    [JsonPropertyName("humidity")]
    [Display(Name = "Humidity: ")]
    public long Humidity { get; set; }

    [JsonPropertyName("cloud")]
    public long Cloud { get; set; }
}

public class Condition
{
    [JsonPropertyName("text")]
    [Display(Name = "Text:")]
    public string Text { get; set; }

    [JsonPropertyName("icon")]
    [Display(Name = "Icon:")]
    public string Icon { get; set; }

    [JsonPropertyName("code")]
    [Display(Name = "Code:")]
    public long Code { get; set; }
}

public class Location
{
    [JsonPropertyName("name")]
    [Display(Name = "Name:")]
    public string Name { get; set; }

    [JsonPropertyName("region")]
    [Display(Name = "Region: ")]
    public string Region { get; set; }

    [JsonPropertyName("country")]
    [Display(Name = "Country: ")]
    public string Country { get; set; }

    [JsonPropertyName("lat")]
    [Display(Name = "Latidtude: ")]
    public double Lat { get; set; }

    [JsonPropertyName("lon")]
    [Display(Name = "Longatidue: ")]
    public double Lon { get; set; }

    [JsonPropertyName("localtime")]
    [Display(Name = "Local time: ")]
    public string Localtime { get; set; }
}
