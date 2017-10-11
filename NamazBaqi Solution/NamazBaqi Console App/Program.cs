using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamazBaqi_Console_App
{
    class Program
    {
        static void Main(string[] args)
        {


            DateTime fajrTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day
                                , 5, 20, 0);
            DateTime zoharTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day
                                , 14, 20, 0);
            DateTime asarTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day
                                , 16, 45, 0);
            DateTime maghribTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day
                                , 18, 00, 0);
            DateTime eshaTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day
                                , 22, 00, 0);
            DateTime tahajudTime = new DateTime(DateTime.Now.AddDays(1).Year, DateTime.Now.AddDays(1).Month, DateTime.Now.AddDays(1).Day
                                , 0, 0, 0);

            TimeSpan fajarTimeRemaining = fajrTime.Subtract(DateTime.Now);
            TimeSpan zoharTimeRemaining = zoharTime.Subtract(DateTime.Now);
            TimeSpan asarTimeRemaining = asarTime.Subtract(DateTime.Now);
            TimeSpan maghribTimeRemaining = maghribTime.Subtract(DateTime.Now);
            TimeSpan eshaTimeRemaining = eshaTime.Subtract(DateTime.Now);
            TimeSpan tahajudTimeRemaining = tahajudTime.Subtract(DateTime.Now);

            Console.WriteLine(fajrTime);
            Console.WriteLine(zoharTime);
            Console.WriteLine(asarTime);
            Console.WriteLine(maghribTime);
            Console.WriteLine(eshaTime);
            Console.WriteLine(tahajudTime);

            if (fajrTime > DateTime.Now)
            {
                TimeSpan t1 = fajarTimeRemaining;
                Console.WriteLine(string.Format("{0}:{1}", t1.Hours, t1.Minutes));
            }
            else if (zoharTime > DateTime.Now)
            {
                TimeSpan t1 = zoharTimeRemaining;
                Console.WriteLine(string.Format("{0}:{1}", t1.Hours, t1.Minutes));
            }
            else if (asarTime > DateTime.Now)
            {
                TimeSpan t1 = asarTimeRemaining;
                Console.WriteLine(string.Format("{0}:{1}", t1.Hours, t1.Minutes));
            }
            else if (maghribTime > DateTime.Now)
            {
                TimeSpan t1 = maghribTimeRemaining;
                Console.WriteLine(string.Format("{0}:{1}", t1.Hours, t1.Minutes));
            }
            else if (eshaTime > DateTime.Now)
            {
                TimeSpan t1 = eshaTimeRemaining;
                Console.WriteLine(string.Format("{0}:{1}", t1.Hours, t1.Minutes));
            }
            else if (tahajudTime>DateTime.Now)
            {
                TimeSpan t1 = tahajudTimeRemaining;
                Console.WriteLine(string.Format("{0}:{1}", t1.Hours, t1.Minutes));
            }

           

            Console.ReadKey();
        }
    }
}
