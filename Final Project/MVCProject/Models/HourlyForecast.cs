using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCProject.Models
{
    public class HourlyForecast : WeatherForecast
    {
        public int percipitationPercent { get; set; }
        public double percipitationAmount { get; set; }
        public int cloudCover { get; set; }
        public int dewPoint { get; set; }
        public int humidity { get; set; }
    }
}
