using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ConsoleApplication
{
    class Class8
    {
        delegate void MyDelegate();

        static void Main(string[] args)
        {
            MyDelegate delegate1 = new MyDelegate(AsyncThread);
            //显示委托类的几个方法成员     
            var methods = delegate1.GetType().GetMethods();
            if (methods != null)
                foreach (MethodInfo info in methods)
                    Console.WriteLine(info.Name);
            Console.ReadKey();
        }

        private static void AsyncThread()
        {
            throw new NotImplementedException();
        }
    }
}
