using System;

namespace ConsoleApplication
{
    internal class Test
    {
        internal int MyInt(string a, string b)
        {
            try
            {
                var int1 = int.Parse(a);
                var int2 = int.Parse(b);
                if (int2 == 0)
                {
                    throw new DivideByZeroException();
                }
                var num = int1 / int2;
                return num;
            }
            catch (DivideByZeroException de)
            {
                Console.WriteLine("用零除整数引发异常");
                Console.WriteLine(de.Message);
                return 0;
            }
        }
    }

    internal class Program
    {

        private static void Main()
        {
            try
            {
                Console.WriteLine("请输入分子：");
                var str1 = Console.ReadLine();
                Console.WriteLine("请输入分母：");
                var str2 = Console.ReadLine();
                var test = new Test();
                Console.WriteLine("分子除以分母的值：" + test.MyInt(str1, str2));
            }
            catch (FormatException)
            {
                Console.WriteLine("请输入数值格式的数据");
            }
            Console.ReadLine();
        }
    }
}