using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WeatherDataApp
{
    public class WeatherDataServiceException : System.Exception
    {
        public WeatherDataServiceException() : base()
        {
        }
        public WeatherDataServiceException(String message) : base(message)
        {
            Console.WriteLine("test exception in WeatherDataServiceException(String message)");
        }
        public WeatherDataServiceException(String message, Exception innerException) : base(message, innerException)
        {
        }
        protected WeatherDataServiceException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

    }
}
