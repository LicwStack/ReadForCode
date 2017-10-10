using System;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        class test
        {
            public int MyInt(string a, string b)
            {
                int int1;
                int int2;
                int num;
                try
                {
                    int1 = int.Parse(a);
                    int2 = int.Parse(b);
                    if (int2 == 0)
                    {
                        throw new DivideByZeroException();
                    }
                    num = int1 / int2;
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

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("请输入分子：");
                string str1 = Console.ReadLine();
                Console.WriteLine("请输入分母：");
                string str2 = Console.ReadLine();
                test tt = new test();
                Console.WriteLine("分子除以分母的值：" + tt.MyInt(str1, str2));
            }
            catch(FormatException)
            {
                Console.WriteLine("请输入数值格式的数据");
            }
            Console.ReadLine();
        }
    }
}