using System;

namespace Prime_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prime Number Program ");
            int prime,count=0;
            Console.Write("Enter The Number To Check Prime or Not : ");
            prime = Convert.ToInt32(Console.ReadLine());

            if (prime == 0 || prime == 1)
            {
                Console.WriteLine("Please Re-enter The Number.");
            }
            for (int i=3;i<prime;i=i+1)
            {
                if ( prime % i == 0 )
                {
                    Console.WriteLine("Number {0} is Not a Prime Number.",prime);
                    count = count + 1;
                    break;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("Number {0} is a Prime Number.", prime);
            }
        }
    }
}
