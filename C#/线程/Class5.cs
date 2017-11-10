using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApplication
{
    class Class5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main threadId is:" +
                              Thread.CurrentThread.ManagedThreadId);

            Thread thread = new Thread(new ThreadStart(AsyncThread));
            thread.IsBackground = true;
            thread.Start();
            thread.Join();

        }

        //以异步方式调用
        static void AsyncThread()
        {
            try
            {
                string message = string.Format("\nAsync threadId is:{0}",
                    Thread.CurrentThread.ManagedThreadId);
                Console.WriteLine(message);

                for (int n = 0; n < 10; n++)
                {
                    //当n等于4时，终止线程
                    if (n >= 4)
                    {
                        Thread.CurrentThread.Abort(n);
                    }
                    Thread.Sleep(300);
                    Console.WriteLine("The number is:" + n.ToString());
                }
            }
            catch (ThreadAbortException ex)
            {
                //输出终止线程时n的值
                if (ex.ExceptionState != null)
                    Console.WriteLine(string.Format("Thread abort when the number is: {0}!",
                        ex.ExceptionState.ToString()));

                //取消终止，继续执行线程
                //Thread.ResetAbort();
                Console.WriteLine("Thread ResetAbort!");
            }

            //线程结束
            Console.WriteLine("Thread Close!");
        }
    }
}
