using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class MyClass
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
        public int Add()
        {
            return X + Y;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass myclass = new MyClass();
            myclass.X = 3;
            myclass.Y = 5;
            Console.WriteLine(myclass.Add());
            Console.ReadLine();
        }
    }
}
