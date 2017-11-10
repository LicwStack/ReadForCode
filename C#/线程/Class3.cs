using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApplication
{
    public class Person
    {
        public string Name
        {
            get;
            set;
        }
        public int Age
        {
            get;
            set;
        }
    }

    public class Message
    {
        public void ShowMessage(object person)
        {
            if (person != null)
            {
                Person _person = (Person)person;
                string message = string.Format("\n{0}'s age is {1}!\nAsync threadId is:{2}",
                    _person.Name, _person.Age, Thread.CurrentThread.ManagedThreadId);
                Console.WriteLine(message);
            }
            for (int n = 0; n < 10; n++)
            {
                Thread.Sleep(300);
                Console.WriteLine("The number is:" + n.ToString());
            }
        }
    }

    class Class3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main threadId is:" + Thread.CurrentThread.ManagedThreadId);

            Message message = new Message();
            //绑定带参数的异步方法
            Thread thread = new Thread(new ParameterizedThreadStart(message.ShowMessage));
            Person person = new Person();
            person.Name = "Jack";
            person.Age = 21;
            thread.Start(person);  //启动异步线程 

            Console.WriteLine("Do something ..........!");
            Console.WriteLine("Main thread working is complete!");

        }
    }
}
