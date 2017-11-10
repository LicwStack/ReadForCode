using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApplication
{
    class Class10
    {
        delegate string MyDelegate(string name);

        static void Main(string[] args)
        {
            ThreadMessage("Main Thread");

            //建立委托
            MyDelegate myDelegate = new MyDelegate(Hello);
            //异步调用委托，获取计算结果
            IAsyncResult result = myDelegate.BeginInvoke("Leslie", null, null);
            //在异步线程未完成前执行其他工作
            while (!result.IsCompleted)
            {
                Thread.Sleep(200);      //虚拟操作
                Console.WriteLine("Main thead do work!");
            }
            string data = myDelegate.EndInvoke(result);
            Console.WriteLine(data);

            Console.ReadKey();
        }

        static string Hello(string name)
        {
            ThreadMessage("Async Thread");
            Thread.Sleep(2000);
            return "Hello " + name;
        }

        static void ThreadMessage(string data)
        {
            string message = string.Format("{0}\n  ThreadId is:{1}",
                data, Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine(message);
        }
    }
}
