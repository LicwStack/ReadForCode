using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    interface ImyInterface
    {
        string ID
        {
            get;
            set;
        }
        string Name
        {
            get;
            set;
        }
        void ShowInfo();
    }

    class Program:ImyInterface
    {
        string id = "";
        string name = "";
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
        public void ShowInfo()
        {
            Console.WriteLine("±àºÅ\t ÐÕÃû");
            Console.WriteLine(ID + "\t " + Name);
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            ImyInterface imyinterface = program;
            imyinterface.ID = "TM";
            imyinterface.Name = "66666";
            imyinterface.ShowInfo();
            Console.ReadLine();
        }
    }
}
