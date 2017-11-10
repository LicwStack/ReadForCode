using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;

namespace ConsoleApplication
{
    class Class13
    {
        delegate string MyDelegate(string name);

        static void Main(string[] args)
        {
            ThreadMessage("Main Thread");

            //建立委托
            MyDelegate myDelegate = new MyDelegate(Hello);
            //异步调用委托，获取计算结果
            myDelegate.BeginInvoke("Leslie", new AsyncCallback(Completed), null);
            //在启动异步线程后，主线程可以继续工作而不需要等待
            for (int n = 0; n < 6; n++)
                Console.WriteLine("  Main thread do work!");
            Console.WriteLine("");

            Console.ReadKey();
        }

        static string Hello(string name)
        {
            ThreadMessage("Async Thread");
            Thread.Sleep(2000);             //模拟异步操作
            return "\nHello " + name;
        }

        static void Completed(IAsyncResult result)
        {
            ThreadMessage("Async Completed");

            //获取委托对象，调用EndInvoke方法获取运行结果
            AsyncResult _result = (AsyncResult)result;
            MyDelegate myDelegate = (MyDelegate)_result.AsyncDelegate;
            string data = myDelegate.EndInvoke(_result);
            Console.WriteLine(data);
        }

        static void ThreadMessage(string data)
        {
            string message = string.Format("{0}\n  ThreadId is:{1}",
                data, Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine(message);
        }
    }
}
