using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Aleatory
{
    static class Program
    {
        public static DateTime startTime = DateTime.Now.Date;
        public static List<DateTime> uniqueDateTime = new List<DateTime>(3) { ChangeTime(startTime, 8, 0, 0, 0), ChangeTime(startTime, 8, 15, 0, 0), ChangeTime(startTime, 11, 00, 0, 0), ChangeTime(startTime, 12, 0, 0, 0) };

        public static void Main(string[] args)
        {
            //var startTime = DateTime.Now.Date;

            //List<DateTime> uniqueDateTime = new List<DateTime>(3) { ChangeTime(startTime, 8, 0, 0, 0), ChangeTime(startTime, 8, 15, 0, 0), ChangeTime(startTime, 11, 00, 0, 0), ChangeTime(startTime, 12, 0, 0, 0) };
            
            foreach (DateTime num in uniqueDateTime)
            {
                Console.Write($"{num}, \n");
            }

            GroupTimeByDate();

            Console.ReadLine();
        }


        public static DateTime ChangeTime(this DateTime dateTime, int hours, int minutes, int seconds, int milliseconds)
        {
            return new DateTime(
                dateTime.Year,
                dateTime.Month,
                dateTime.Day,
                hours,
                minutes,
                seconds,
                milliseconds,
                dateTime.Kind);
        }

        public static void GroupTimeByDate()
        {
            var list = uniqueDateTime.OrderBy(x => x.TimeOfDay).ToList();

            foreach (DateTime ItemDateTime in list)
            {
                Console.WriteLine(ItemDateTime);
            }
        }
    }
}
