using System;
using System.Globalization;
using System.IO;
using System.Linq;

namespace StockAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Module 2 Part 2
            //var lines = File.ReadAllLines(@"StockData.csv");

            //foreach (var line in lines.Skip(1))
            //{
            //    var segments = line.Split(",");

            //    var tradeDate = DateTime.Parse(segments[1], CultureInfo.GetCultureInfo("en-GB"));

            //    Console.WriteLine(tradeDate.ToLongDateString());
            //}

            //Module 2 Part 3
            //var now = DateTime.Now;

            //TimeZoneInfo sydneyTimeZone = TimeZoneInfo.FindSystemTimeZoneById("E. Australia Standard Time");

            //var sydneyTime = TimeZoneInfo.ConvertTime(now, sydneyTimeZone);

            //Console.WriteLine(now);
            //Console.WriteLine(sydneyTime);

            //Module 2 Part 4
            //var time = DateTimeOffset.Now.ToOffset(TimeSpan.FromHours(10));
            //foreach (var timezone in TimeZoneInfo.GetSystemTimeZones())
            //{
            //    if(timezone.GetUtcOffset(time) == time.Offset)
            //    {
            //        Console.WriteLine(timezone);
            //    }
            //}

            //Module 2 Part 5
            var date = "2019-07-01 10:00:00 PM +02:00";

            var parsedDate = DateTime.Parse(date, CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal);

            Console.WriteLine(parsedDate);
            Console.WriteLine(parsedDate.Kind);
        }
    }
}
