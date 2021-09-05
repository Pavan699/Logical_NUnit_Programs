using System;

namespace Temperatur_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Temperatur Conversion Program");
            double temp;
            Console.Write("Enter The Temperatur : ");
            temp = Convert.ToInt32(Console.ReadLine());
            Calculate.tempCal(temp);
        }
    }
}
