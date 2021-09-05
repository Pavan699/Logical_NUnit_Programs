using System;
using System.Collections.Generic;
using System.Text;

namespace Monthly_Payment
{
    class Calculate
    {
        public static void monthlyPayment(double amount,double year,double intrest)
        {
            double total_Amount,r,n;
            n = 12 * year;
            r = intrest / (12*100);
            total_Amount = (amount * r) / (1 - Math.Abs(Math.Pow((1+r),(-n))));
            Console.WriteLine("The Total Monthly Payment is : " + total_Amount);
            
        }
    }
}
