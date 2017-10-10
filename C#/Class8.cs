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
                    Console.WriteLine("��������������쳣");
                    Console.WriteLine(de.Message);
                    return 0;
                }
            }
        }

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("��������ӣ�");
                string str1 = Console.ReadLine();
                Console.WriteLine("�������ĸ��");
                string str2 = Console.ReadLine();
                test tt = new test();
                Console.WriteLine("���ӳ��Է�ĸ��ֵ��" + tt.MyInt(str1, str2));
            }
            catch(FormatException)
            {
                Console.WriteLine("��������ֵ��ʽ������");
            }
            Console.ReadLine();
        }
    }
}