using System;

namespace Binary_Number
{
    class Program
    {
        static void toBinary(int num)
        {
            int i;
            int[] a = new int[9];
            for (i = 0; num > 0; i++)
            {
                a[i] = num % 2;
                num = num / 2;
            }
            Console.Write("Binary Numbers is : ");
            for (i = i - 1; i >= 0; i--)
            {
                Console.Write(a[i]);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Binary Number Conversion Program");
            int Number;
            Console.Write("Enter The Number to convert in Binary : ");
            Number = Convert.ToInt32(Console.ReadLine());
            toBinary(Number);
        }
    }
}
