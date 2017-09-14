using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WeatherDataApp
{
    public interface IWeatherDataService
    {
        WeatherData GetWeatherData(Location location);
    }



    public class WeatherDataServiceFactory: IWeatherDataService
    {
        private static WeatherDataServiceFactory instance;
        private WeatherDataServiceFactory() { }
        public static WeatherDataServiceFactory Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new WeatherDataServiceFactory();
                }
                return instance;
            }
        }

        public static void test()
        {
            Console.WriteLine("In test");
        }

        public WeatherData GetWeatherData(Location location)
        {
            return new WeatherData();
        }
    }



}
