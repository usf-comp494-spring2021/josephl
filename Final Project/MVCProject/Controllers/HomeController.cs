using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCProject.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Json;


namespace MVCProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHttpClientFactory clientFactory;

        public HomeController(ILogger<HomeController> logger, IHttpClientFactory httpClientFactory)
        {
            _logger = logger;
            clientFactory = httpClientFactory;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public async Task<IActionResult> Weather()
        {
            string uri;

            ViewData["Title"] = $"Local Weather";
            uri = $"http://csc494a-sp21-final.azurewebsites.net/WeatherForecast";

            var client = clientFactory.CreateClient(
                name: "COMP494_FINAL");

            var request = new HttpRequestMessage(
                method: HttpMethod.Get, requestUri: uri);

            HttpResponseMessage response = await client.SendAsync(request);

            var model = await response.Content.ReadFromJsonAsync<WeatherForecast>();


            return View(model);
        }

        public async Task<IActionResult> HourlyForecast()
        {
            string uri;

            ViewData["Title"] = $"Hourly Weather";
            uri = $"http://csc494a-sp21-final.azurewebsites.net/WeatherForecast/hourly";

            var client = clientFactory.CreateClient(
                name: "COMP494_FINAL");

            var request = new HttpRequestMessage(
                method: HttpMethod.Get, requestUri: uri);

            HttpResponseMessage response = await client.SendAsync(request);

            var model = await response.Content.ReadFromJsonAsync<IEnumerable<HourlyForecast>>();


            return View(model);
        }

        public async Task<IActionResult> DetailedForecast()
        {
            string uri;

            ViewData["Title"] = $"Detailed Forecast";
            uri = $"http://csc494a-sp21-final.azurewebsites.net/WeatherForecast/details";

            var client = clientFactory.CreateClient(
                name: "COMP494_FINAL");

            var request = new HttpRequestMessage(
                method: HttpMethod.Get, requestUri: uri);

            HttpResponseMessage response = await client.SendAsync(request);

            var model = await response.Content.ReadFromJsonAsync<DetailedForecast>();


            return View(model);
        }
    }
}
