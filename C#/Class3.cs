using System;

namespace ConsoleApplication
{
    internal class Program
    {
        private class C
        {
            public int Value;
        }
        private static void Main()
        {
            const int v1 = 0;
            const int v2 = 927;
            var r1 = new C();
            var r2 = r1;
            r2.Value = 112;
            Console.WriteLine("Values:{0},{1}", v1, v2);
            Console.WriteLine("Refs:{0},{1}", r1.Value, r2.Value);
            Console.ReadLine();
        }
    }
}