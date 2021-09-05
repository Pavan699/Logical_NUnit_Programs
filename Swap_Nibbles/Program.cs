using System;

namespace Swap_Nibbles
{
    class Program
    {
        static int check(int x)
        {
            return ((x & 0x0F) <<4 | (x & 0xF0) >> 4);
        }
        static void toBinary(int num)
        {
            int i;
            int[] a = new int[8];
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
            Console.WriteLine(" ");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Swap-Nibble Program");
            int Number;
            Console.Write("Enter The Number to convert in Binary : ");
            Number = Convert.ToInt32(Console.ReadLine());
            toBinary(Number);
            Console.Write("Swap Number is :");
            Console.WriteLine(check(Number));
        }
    }
}
