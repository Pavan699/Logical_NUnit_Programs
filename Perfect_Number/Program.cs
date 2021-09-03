using System;

namespace Perfect_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Perfect Number Checking Program");
            int Number, addition = 0;
            Console.Write("Enter The Number To Check : ");
            Number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < Number; i = i+1 )
            {
                if ( Number % i == 0)
                {
                    addition = addition + i;
                    Console.Write(i+" ");
                }
            }
            Console.WriteLine(" ");
            if (addition == Number)
            {
                Console.WriteLine("The Number {0} is a Perfect Number.",Number);
            }
            else
            {
                Console.WriteLine("The Number {0} is Not a Perfect Number.", Number);
            }
        }
    }
}
