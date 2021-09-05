using System;

namespace Coupon_Number
{
    class Program
    {
        static void Coupon(int n)
        {
            int[] originCoupon = new int[n];
            int[] outputCoupon = new int[n];
            Console.WriteLine(" Original(Repeated) Coupons are : ");
            for (int i = 1; i < n; i++)
            {
                Random random = new Random();
                int num = random.Next(0, 11);
                originCoupon[i] = num;
                Console.Write(" " + originCoupon[i]);
            }

            Console.WriteLine(" ");
            Console.WriteLine(" Non Repeated Coupons are : ");

            int j = 0;
            for (int i = 0; i < n; i++)
            {
                int count = 1;
                for (int k = 0; k < i; k++)
                {
                    if (originCoupon[i] == originCoupon[k])
                    {
                        count++;
                    }
                }
                outputCoupon[j] = count;
                j++;
            }
            for (int i = 0; i < n; i++)
            {
                if (outputCoupon[i] == 1)
                {
                    Console.Write(" " + originCoupon[i]);
                }
            }


        }
        static void Main(string[] args)
        {
            Console.WriteLine("Coupon Number Program");
            int Number;
            Console.Write("Enter The Repetations For Random : ");
            Number = Convert.ToInt32(Console.ReadLine());
            Coupon(Number);
        }
    }
}
