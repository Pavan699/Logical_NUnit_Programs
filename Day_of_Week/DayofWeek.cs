using System;
using System.Collections.Generic;
using System.Text;

namespace Day_of_Week
{
    class DayofWeek
    {
        public static void dayOfWeek(int m,int d,int y)
        {
            int y0, m0, d0,x;
            string[] days = {"Sunday","Monday","Tuesday","Wednesday","Thursday","Firday","Saturday"};
            string[] month = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sept","Oct","Nov","Dec"};
            y0 = y - ((14 - m) / 12);
            x = y0 + (y0 / 4) - (y0 / 100) + (y0 / 40);
            m0 = m + 12 * ((14 - m) / 12) - 2;   
            d0 = (d + x + 31 + (m0 / 12)) % 7;
            Console.WriteLine("The Day,Month and Year of Entered Date is : {0}_{1}_{2}",days[d0-1],month[m-1],y0);
        }
    }
}
