using System;

namespace Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Day of week Program");
            int m, d, y;
            Console.Write("Enter the Month :");
            m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the day of the Month :");
            d = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Year :");
            y = Convert.ToInt32(Console.ReadLine());
            DayofWeek.dayOfWeek(m,d,y); 
        }
    }
}
