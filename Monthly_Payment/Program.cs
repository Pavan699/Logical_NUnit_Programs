using System;

namespace Monthly_Payment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program To Calculate Monthly Payment");
            double Y, P, R;
            Console.Write("Enter The Ammount Of Loan : ");
            P = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter The Year For Loan : ");
            Y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter The Intrest Percentage For the loan : ");
            R = Convert.ToInt32(Console.ReadLine());
            Calculate.monthlyPayment(P, Y, R);
        }
    }
}
