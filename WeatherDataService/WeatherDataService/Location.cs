using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherDataApp
{
    public class Location
    {
        private string cityName;
        private string country { get; set; }
        private string weatherDescription { get; set; }
        private string temperature { get; set; }
        private string temperatureMax { get; set; }
        private string temperatureMin { get; set; }
        private string humidity { get; set; }
        private string windSpeed { get; set; }
        private string sunset { get; set; }
        private string sunrise { get; set; }
        private string lastUpdate { get; set; }

        public Location() { }

        public Location (string city) { cityName = city; }

    }
}
