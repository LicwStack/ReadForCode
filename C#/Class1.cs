using System;
using N1;

namespace Test02
{
    class Program
    {
        static void main(string[] args)
        {
            A oa = new A();
            oa.Myls();
        }
    }
}

namespace N1
{
    class A
    {
        public void Myls()
        {
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
