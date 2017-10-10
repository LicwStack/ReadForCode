using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class myClass1
    {
        public virtual void ShowInfo()
        {
        }
    }

    public sealed class myClass2 : myClass1 
    {
        private string id = "";
        private string name = "";
        public string ID
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public sealed override void ShowInfo()
        {
            Console.WriteLine(ID + " " + Name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            myClass2 myclass2 = new myClass2();
            myclass2.ID = "234";
            myclass2.Name  = "sdfds";
            myclass2.ShowInfo();
            Console.ReadLine();
        }
    }
}
