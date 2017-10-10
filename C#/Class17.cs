using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class myClass1
    {
        public virtual void Method()
        {
            Console.WriteLine("base class's virtual method");
        }
    }

    public sealed class myClass2 : myClass1 
    {
        public sealed override void Method()
        {
            base.Method();
            Console.WriteLine("aloha");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            myClass1 myclass1 = new myClass1();
            myClass2 myclass2 = new myClass2();
            myclass1.Method();
            myclass2.Method();
            Console.ReadLine();
        }
    }
}
