using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fibonacci Series Program");
            int num1 = 0, num2 = 1, num3, Number;
            Console.Write("Enter The Number of Elements You Wan't :");
            Number = Convert.ToInt32(Console.ReadLine());
            Console.Write(num1 + " " + num2 + " ");
            for (int i = 2; i < Number; i++)
            {
                num3 = num1 + num2;
                Console.Write(num3 + " ");
                num1 = num2;
                num2 = num3;
            }
        }
    }
}
