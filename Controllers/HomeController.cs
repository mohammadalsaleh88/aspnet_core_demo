using System.Diagnostics;
using aspnet_core_demo.Models;
using Microsoft.AspNetCore.Mvc;

namespace aspnet_core_demo.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Index()
    {
        var model = new WeatherModel { CityName = string.Empty };

        return View(model);
    }

    [HttpPost]
    public async Task<IActionResult> IndexAsync(WeatherModel model)
    {
        using (var client = new HttpClient())
        {
            var response = await client.GetAsync(
                $"https://api.weatherapi.com/v1/current.json?key=ff21e45c2a294d00a94135445220304&q={model.CityName}&aqi=no"
            );

            var result = await response.Content.ReadAsStringAsync();

            var weatherResult = System
                .Text
                .Json
                .JsonSerializer
                .Deserialize<WeatherResultModel>(result);

            model.Result = weatherResult;

            return View(model);
        }
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(
            new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier }
        );
    }
}
