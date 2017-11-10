using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApplication
{
    public class Message
    {
        public void ShowMessage()
        {
            string message = string.Format("Async threadId is :{0}",
                Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine(message);

            for (int n = 0; n < 10; n++)
            {
                Thread.Sleep(300);
                Console.WriteLine("The number is:" + n.ToString());
            }
        }
    }

    class Class2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main threadId is:" +
                              Thread.CurrentThread.ManagedThreadId);
            Message message = new Message();
            Thread thread = new Thread(new ThreadStart(message.ShowMessage));
            thread.Start();
            Console.WriteLine("Do something ..........!");
            Console.WriteLine("Main thread working is complete!");

        }
    }
}
