using System;

namespace ConsoleApplication
{
    internal class Program
    {
        private static void Main()
        {
            ReferenceAndValue.Demonstration();
            Console.ReadLine();
        }

        public class Stamp
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }

        public static class ReferenceAndValue
        {
            public static void Demonstration()
            {
                Stamp stamp1 = new Stamp { Name = "Premiere", Age = 25 };
                Stamp stamp2 = new Stamp { Name = "Again", Age = 47 };
                int age = stamp1.Age;
                stamp1.Age = 22;
                Stamp guru = stamp2;
                stamp2.Name = "Again Amend";
                Console.WriteLine("Stamp_1's age:{0}", stamp1.Age);
                Console.WriteLine("age's value:{0}", age);
                Console.WriteLine("Stamp_2's name:{0}", stamp2.Name);
                Console.WriteLine("guru's name:{0}", guru.Name);
            }
        }
    }
}