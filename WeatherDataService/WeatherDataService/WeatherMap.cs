using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WeatherDataService
{
    class WeatherMap: WeatherData,IWeatherDataService
    {
        private string urlString; 

        public override WeatherData GetWeatherData(Location location)
        {
            location.cityName = location.cityName;
            getDataFromOpenWeatherMap(this, location);
            return this;
        }

        public void getDataFromOpenWeatherMap(WeatherMap wm,Location location)
        {
            urlString = Properties.Settings.Default.url + location.cityName + "&mode=xml&units=metric&appid=" + Properties.Settings.Default.key;
            string xmlResponse;
            XDocument xmlDoc;
            WebClient client = new WebClient();
            try
            {
                xmlResponse = client.DownloadString(urlString);
            }
            catch (Exception e)
            {
                throw new WeatherDataServiceException("Web exception: " + e.Message.ToString());
            }
            try
            {
                xmlDoc = XDocument.Parse(xmlResponse);
                wm.location.cityName = xmlDoc.Descendants("city").Attributes("name").First().Value;
                wm.location.weatherDescription = xmlDoc.Descendants("weather").Attributes("value").First().Value;
                wm.location.temperature = xmlDoc.Descendants("temperature").Attributes("value").First().Value;
                wm.location.maxTemperature = xmlDoc.Descendants("temperature").Attributes("max").First().Value;
                wm.location.minTemperature = xmlDoc.Descendants("temperature").Attributes("min").First().Value;
                wm.location.humidity = xmlDoc.Descendants("humidity").Attributes("value").First().Value;
                wm.location.windSpeed = xmlDoc.Descendants("speed").Attributes("name").First().Value;
                wm.location.sunset = xmlDoc.Descendants("sun").Attributes("set").First().Value;
                wm.location.sunrise = xmlDoc.Descendants("sun").Attributes("rise").First().Value;
                wm.location.lastUpdate = xmlDoc.Descendants("lastupdate").Attributes("value").First().Value;
            }
            catch (Exception e)
            {
                throw new WeatherDataServiceException("XML exception: " + e.Message.ToString());
            }
            
        }

    }
}
