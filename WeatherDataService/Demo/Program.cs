using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using WeatherDataService;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {     
            Location location = new Location();
            using (WebClient client = new WebClient())
            {
                string xml = client.DownloadString(Properties.Settings.Default.url + "zip=94040&mode=xml&units=metric&appid=" + Properties.Settings.Default.key);
            }
            try
            {
                throw new WeatherDataServiceException("test exception");
            }
            catch(WeatherDataServiceException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
