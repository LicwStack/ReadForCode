using System;

namespace ConsoleApplication
{
    internal class Program
    {
        public struct Rect
        {
            public double Width;
            public double Height;
            public Rect(double x, double y)
            {
                Width = x;
                Height = y;
            }

            public double Area()
            {
                return Width * Height;
            }
        }

        private static void Main()
        {
            Rect rect1;
            rect1.Width = 5;
            rect1.Height = 3;
            Console.WriteLine("rect1's Area:" + rect1.Area());
            var rect2 = new Rect(6, 4);
            Console.WriteLine("rect2's Area:" + rect2.Area());
            Console.ReadLine();
        }
    }
}