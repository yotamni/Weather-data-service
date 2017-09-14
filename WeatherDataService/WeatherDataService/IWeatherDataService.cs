using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WeatherDataService
{
    public interface IWeatherDataService
    {
        WeatherData GetWeatherData(Location location);
    }
}
