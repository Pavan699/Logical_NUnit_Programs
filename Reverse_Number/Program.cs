using System;

namespace Reverse_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reverse Number Program");
            int Number,remainder,reverse = 0;
            Console.Write("Enter The Number To Reverse : ");
            Number = Convert.ToInt32(Console.ReadLine());

            while(Number != 0)
            {
                remainder = Number % 10;
                reverse = reverse * 10 + remainder;
                Number = Number / 10;
            }
            Console.Write("Reverse  Number is : {0}",reverse);

        }
    }
}
