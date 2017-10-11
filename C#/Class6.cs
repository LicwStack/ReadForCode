using System;

namespace ConsoleApplication
{
    internal class Program
    {
        private static void Main()
        {
            const double x = 198103423.23234;
            const int y = (int)x;
            Console.WriteLine(y);
            var z = Convert.ToInt32(x);
            Console.WriteLine(z);
            Console.ReadLine();
        }
    }
}