using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApplication
{
    class Class9
    {
        delegate string MyDelegate(string name);

        static void Main(string[] args)
        {
            ThreadMessage("Main Thread");
            
            //建立委托
            MyDelegate myDelegate = new MyDelegate(Hello);
            //异步调用委托，获取计算结果
            IAsyncResult result=myDelegate.BeginInvoke("Leslie", null, null);
                //完成主线程其他工作
                //............. 
            //等待异步方法完成，调用EndInvoke(IAsyncResult)获取运行结果
            string data=myDelegate.EndInvoke(result);
            Console.WriteLine(data);
            
            Console.ReadKey();
        }

        static string Hello(string name)
        {
            ThreadMessage("Async Thread");
            Thread.Sleep(2000);            //虚拟异步工作
            return "Hello " + name;
        }

        //显示当前线程
        static void ThreadMessage(string data)
        {
            string message = string.Format("{0}\n  ThreadId is:{1}",
                data, Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine(message);
        }
    }
}
