using System;

namespace Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Vending Machine Program");
            int Rs;
            Console.Write("Enter The Ammount To Withdrow : ");
            Rs = Convert.ToInt32(Console.ReadLine());
            ATM a = new ATM();
            a.Check(Rs);
        }
    }
}
