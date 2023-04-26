using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    public static class TempConverter
    {
        public static double FahrenheitToCelsius(double deg)
        {
         
            return (deg - 32)* 5/9;
        }

        public static double CelsiusToFahrenheit(double deg)
        {
           return (deg * 9 / 5) + 32; ;
        }


    }
}
