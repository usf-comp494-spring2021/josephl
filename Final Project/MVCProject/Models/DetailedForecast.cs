using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCProject.Models
{
    public class DetailedForecast : WeatherForecast
    {
        public int visibility { get; set; }
        public string clouds { get; set; }
        public int humidity { get; set; }
        public double rainfall { get; set; }
        public double snowfall { get; set; }
    }
}
