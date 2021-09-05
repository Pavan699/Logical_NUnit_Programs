using System;
using System.Collections.Generic;
using System.Text;

namespace Temperatur_Conversion
{
    class Calculate
    {
        public static void tempCal(double t)
        {
            int num;
            Console.Write("Entered the Value is Celsius==1 OR Fahranheit==2 : ");
            num = Convert.ToInt32(Console.ReadLine());
            double fahrenheit, celsius;
            if (num == 1)
            {
                celsius = t;
                fahrenheit = Math.Abs((celsius * (1.8)) + 32);
                Console.WriteLine("If Temperatur is In Celsiun {0} then Converted Fehrenhnit is : {1}", t, fahrenheit);
            }
            if (num == 2)
            {
                fahrenheit = t;
                celsius = (Math.Abs(fahrenheit - 32) * (0.55));
                Console.WriteLine("If Temperatur is In Fehrenhnit {0} then Converted Celsiun is : {1}", t, celsius);
            }
            if (num != 1 && num != 2)
            {
                Console.WriteLine("Enter Wrong Input :)");
            }
        }
    }
}
