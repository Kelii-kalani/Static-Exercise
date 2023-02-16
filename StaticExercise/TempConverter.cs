using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    internal static class TempConverter
    {
        static TempConverter()
        {

        }

        public static double FarenheitToCelsius(double farenheit)
        {
            double celsius = (farenheit - 32)/1.8;
            return celsius;
        }

        public static double CelsiusToFarenheit(double celsius)
        {  
            double farenheit = (celsius * 1.8) + 32;
            return farenheit;
        }
    }
}
