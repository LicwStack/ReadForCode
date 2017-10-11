using System;
using N1;

namespace N
{
    internal class Program
    {
        private static void Main()
        {
            var oa = new A();
            oa.Myls();
        }
    }
}

namespace N1
{
    internal class A
    {
        public void Myls()
        {
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
