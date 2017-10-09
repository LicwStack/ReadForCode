using System;

namespace ConsoleApplication1
{
    class Program
    {
        public struct Rect
        {
            public double width;
            public double height;
            public Rect(double x, double y)
            {
                width = x;
                height = y;
            }

            public double Area()
            {
                return width * height;
            }
        }

        static void Main(string[] args)
        {
            Rect rect1;
            rect1.width = 5;
            rect1.height = 3;
            Console.WriteLine("rect1's Area:"+ rect1.Area());
            Rect rect2 = new Rect(6, 4);
            Console.WriteLine("rect2's Area:" + rect2.Area());
            Console.ReadLine();
        }
    }
}