using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class MyClass1
    {
        private int x = 0;
        private int y = 0;

        public int X
        {
            get
            {
                return x;
            }
            set 
            {
                x = value;
            }
        }
        public int Y
        {
            get
            {
                return y;
            }
            set 
            {
                y = value;
            }
        }
        public int Add1()
        {
            return X + Y;
        }
    }

    class MyClass2 : MyClass1
    {
        private int z = 0;
        public int Z
        {
            get
            {
                return z;
            }
            set
            {
                z = value;
            }
        }
        public int Add2()
        {
            return X + Y + Z;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass1 myclass1 = new MyClass1();
            MyClass2 myclass2 = new MyClass2();
            myclass1.X = 3;
            myclass1.Y = 5;
            myclass2.X = 3;
            myclass2.Y = 5;
            myclass2.Z = 7;
            Console.WriteLine(myclass1.Add1());
            Console.WriteLine(myclass2.Add1());
            Console.WriteLine(myclass2.Add2());
            Console.ReadLine();
        }
    }
}
