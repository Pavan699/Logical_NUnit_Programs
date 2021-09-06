using System;

namespace Sqrt_Method
{
    class Program
    {
        public static double SqrtFun(double n, double ep)
        {
            double t = n;
            double root;
            int count = 0;
            while (true)
            {
                count++;
                root = 0.5 * (t + (n / t));

                if (Math.Abs(root - t) < ep)
                    break;
                t = root;
            }
            return t;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Program To Compute Square Root.");
            Console.Write("Enter the Number To check the SquareRoot :");
            double c = double.Parse(Console.ReadLine());
            double epsilon = 0.000000000000001;
            SqrtFun(c,epsilon);
        }
    }
}
