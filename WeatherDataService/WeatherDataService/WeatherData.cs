using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherDataService
{
    public class WeatherData
    {
        public Location location { get; set; }

        public WeatherData() { this.location = new Location(); }

        public virtual WeatherData GetWeatherData(Location location)
        {
            throw new WeatherDataServiceException("Not implemented Exception: GetWeatherData() not implemented in WeatherData");
        }
    }
}
