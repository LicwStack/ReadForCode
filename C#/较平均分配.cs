using System;
using System.Collections;


// 平均分配
namespace ConsoleApplication1
{
    internal static class Program
    {
        private static void Main()
        {
            foreach (var test in OptimumAllocation(9, 4))
            {
                Console.WriteLine(test);

            }
            Console.ReadKey();
        }

        private static ArrayList OptimumAllocation(int total, int number)
        {
            var returnArrayList = new ArrayList();
            var average = total / number;
            var remainder = total % number;

            for (var i = 0; i < number; i++)
            {
                if (i < remainder)
                {
                    returnArrayList.Add(average + 1);
                }
                else
                {
                    returnArrayList.Add(average);
                }
            }
            return returnArrayList;
        }
    }
}
