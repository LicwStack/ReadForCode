using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 198103423.23234;
            int y = (int)x;
            Console.WriteLine(y);
            int z = Convert.ToInt32(x);
            Console.WriteLine(z);
            Console.ReadLine();
        }
    }
}