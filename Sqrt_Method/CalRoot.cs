using System;
using System.Collections.Generic;
using System.Text;

namespace Sqrt_Method
{
    class CalRoot
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
    }
}
