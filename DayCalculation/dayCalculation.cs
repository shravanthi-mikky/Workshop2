using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayCalculation
{
    public class dayCalculation
    {
      
        public int date;
        public int month;
        public int year;
        public void DayDetection()
        {
            Console.WriteLine("Please enter the date :");
            date = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the month :");
            month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the Year :");
            year = Convert.ToInt32(Console.ReadLine());
            double y0, m0, x, d0;
            y0 = year - (14 - month) / 12;
            x = y0 + (y0 / 4) - (y0 / 100) + (y0 / 400);
            m0 = month + (12 * ((14 - month) / 12) )- 2;
            d0 = Math.Floor((date + (x + (31 * m0)/12)) % 7);
            Console.WriteLine(d0);
            if (d0 == 1)
            {
                Console.WriteLine("The day is Monday.");
            }
            else if (d0 == 2)
            {
                Console.WriteLine("The day is Tuesday.");
            }
            else if (d0 == 3)
            {
                Console.WriteLine("The day is Wednesday.");
            }
            else if (d0 == 4)
            {
                Console.WriteLine("The day is Thursday.");
            }
            else if (d0 == 5)
            {
                Console.WriteLine("The day is Friday.");
            }
            else if (d0 == 6)
            {
                Console.WriteLine("The day is Saturday.");
            }
            else
            {
                Console.WriteLine("The day is Sunday.");
            }
        }
    }
}
