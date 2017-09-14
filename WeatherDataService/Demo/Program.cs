using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using WeatherDataService;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {     
            Location location = new Location();
            WebClient client = new WebClient();      
                try
                {
                    XDocument xmlDoc;
                    string xml = client.DownloadString(Properties.Settings.Default.url + "q=Liverpool&mode=xml&units=metric&appid=" + Properties.Settings.Default.key);
                    xmlDoc = XDocument.Parse(xml);
                    var city = xmlDoc.Descendants("city").Attributes("name").First().Value;
                    var weatherDescription = xmlDoc.Descendants("weather").Attributes("value").First().Value;
                    var temperature = xmlDoc.Descendants("temperature").Attributes("value").First().Value;
                    var maxTemperatura = xmlDoc.Descendants("temperature").Attributes("max").First().Value;
                    var minTemperatura = xmlDoc.Descendants("temperature").Attributes("min").First().Value;
                    var humidity = xmlDoc.Descendants("humidity").Attributes("value").First().Value;
                    var wind = xmlDoc.Descendants("speed").Attributes("name").First().Value;
                    var sunset = xmlDoc.Descendants("sun").Attributes("set").First().Value;
                    var sunrise = xmlDoc.Descendants("sun").Attributes("rise").First().Value;
                    var lastUpdate = xmlDoc.Descendants("lastupdate").Attributes("value").First().Value;
                    //WeatherDataServiceFactory.OPEN_WEATHER_MAP.IWeatherDataService service = WeatherDataServiceFactory.GetWeatherDataService(WeatherDataServiceFactory.OPEN_WEATHER_MAP)
                }
                catch 
                {          
                    try
                    {
                        throw new WeatherDataServiceException("test exception");
                    }
                    catch (WeatherDataServiceException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }

            

            Console.ReadLine();  
        }
    }
}
