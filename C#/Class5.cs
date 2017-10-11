using System;

namespace ConsoleApplication
{
    internal class Program
    {
        private enum MyDate
        {
            Sun = 0,
            Mon = 1,
            Tue = 2,
            Wed = 3,
            Thi = 4,
            Fri = 5,
            Sat = 6
        }
        private static void Main()
        {
            var k = (int)DateTime.Now.DayOfWeek;
            switch (k)
            {
                case (int)MyDate.Sun: Console.WriteLine("Today is Sunday"); break;
                case (int)MyDate.Mon: Console.WriteLine("Today is Monday"); break;
                case (int)MyDate.Tue: Console.WriteLine("Today is Tuesday"); break;
                case (int)MyDate.Wed: Console.WriteLine("Today is Wednesday"); break;
                case (int)MyDate.Thi: Console.WriteLine("Today is Thursday"); break;
                case (int)MyDate.Fri: Console.WriteLine("Today is Friday"); break;
                case (int)MyDate.Sat: Console.WriteLine("Today is Saturday"); break;
                default: Console.WriteLine("Error"); break;
            }
            Console.ReadLine();
        }
    }
}