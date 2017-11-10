using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApplication
{
    class Class6
    {
        static void Main(string[] args)
        {
            //把CLR线程池的最大值设置为1000
            ThreadPool.SetMaxThreads(1000, 1000);
            //显示主线程启动时线程池信息
            ThreadMessage("Start");
            //启动工作者线程
            ThreadPool.QueueUserWorkItem(new WaitCallback(AsyncCallback));
            Console.ReadKey();
        }

        static void AsyncCallback(object state)
        {
            Thread.Sleep(200);
            ThreadMessage("AsyncCallback");
            Console.WriteLine("Async thread do work!");
        }

        //显示线程现状
        static void ThreadMessage(string data)
        {
            string message = string.Format("{0}\n  CurrentThreadId is {1}",
                data, Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine(message);
        }
    }
}
