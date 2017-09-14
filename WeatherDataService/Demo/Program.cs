using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using WeatherDataApp;


namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {     
            Location location = new Location();
            using (WebClient client = new WebClient())
            {
                try
                {
                    string xml = client.DownloadString(Properties.Settings.Default.url + "q=Tel Aviv&mode=xml&units=metric&appid=" + Properties.Settings.Default.key);              
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

            }
            
            
        }
    }
}
