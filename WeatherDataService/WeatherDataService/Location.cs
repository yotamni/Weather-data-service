using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherDataService
{
    public class Location
    {
        public string cityName { get; set; }
        public string weatherDescription { get; set; }
        public string temperature { get; set; }
        public string maxTemperature { get; set; }
        public string minTemperature { get; set; }
        public string humidity { get; set; }
        public string windSpeed { get; set; }
        public string sunset { get; set; }
        public string sunrise { get; set; }
        public string lastUpdate { get; set; }

        public Location() { }

        public Location (string city) { cityName = city; }

    }
}
