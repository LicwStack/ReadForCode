using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApplication
{
    class Class7
    {
        static void Main(string[] args)
        {
            //把线程池的最大值设置为1000
            ThreadPool.SetMaxThreads(1000, 1000);

            ThreadMessage("Start");
            ThreadPool.QueueUserWorkItem(new WaitCallback(AsyncCallback), "Hello Elva");
            Console.ReadKey();
        }

        static void AsyncCallback(object state)
        {
            Thread.Sleep(200);
            ThreadMessage("AsyncCallback");

            string data = (string)state;
            Console.WriteLine("Async thread do work!\n" + data);
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
