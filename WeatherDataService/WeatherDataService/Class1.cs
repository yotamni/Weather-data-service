using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WeatherDataService
{
    public interface IWeatherDataService
    {
        WeatherData GetWeatherData(Location location);
    }

    public class WeatherData
    {

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

    public class Location
    {
        string name;
        int id;
        int zipCode;

        public Location(string name="",int id=-1,int zipCode=-1)
        {
           this.name = name;
            this.id = id;
            this.zipCode = zipCode;
        }
        
    }

    public class WeatherDataServiceException: System.Exception
    {
        public WeatherDataServiceException() : base()
        {
        }
        public WeatherDataServiceException(String message) : base(message)
        {
            Console.WriteLine("test exception in WeatherDataServiceException(String message)");
        }
        public WeatherDataServiceException(String message, Exception innerException): base(message, innerException)
        {
        }
        protected WeatherDataServiceException(SerializationInfo info, StreamingContext context): base(info, context)
        {
        }

    }
}
