using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Csharrpday3
{
    class date
    {
        public static void Date()
        {
            var Datetime = new DateTime();
            var today = DateTime.Today;

            var now=DateTime.Now;
            Console.WriteLine("hour "+now.Hour);
            Console.WriteLine("Minute "+now.Minute);
            Console.WriteLine("Second "+now.Second);
            var tommorrow=now.AddDays(1);
            var yesterday = now.AddDays(-2);
            Console.WriteLine(tommorrow);
            Console.WriteLine();
            Console.WriteLine(now);
            Console.WriteLine(today);

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            
             var hello=now.ToString();
            Console.WriteLine(hello);
            Console.WriteLine(now.ToString("yyyy-MM-dd HH" ));
        }
        public static void Time()
        {
            
            var timespan = new TimeSpan(1,2,3);
            var timespan2 = TimeSpan.FromHours(1);
            var start=DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end-start;

            Console.WriteLine(duration);
            Console.WriteLine(timespan2);
            Console.WriteLine(timespan);
            Console.WriteLine("minutes "+timespan.Minutes);
            Console.WriteLine("Hour "+timespan.Hours);
            Console.WriteLine("total minutes "+timespan.TotalMinutes);
            Console.WriteLine("Add example "+timespan.Add(timespan.Add(TimeSpan.FromMinutes(8))));
            Console.WriteLine("Substract example "+timespan.Subtract(TimeSpan.FromMinutes(12)));
            Console.WriteLine("ToString "+timespan.ToString());
            Console.WriteLine("to parse " + TimeSpan.Parse("01:02:03"));


        }
    }
}
