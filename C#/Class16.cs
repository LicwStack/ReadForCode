using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public abstract class myClass
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
        public abstract void ShowInfo();
    }

    public class DriveClass : myClass 
    {
        public override void ShowInfo()
        {
            Console.WriteLine(ID + " " + Name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DriveClass driveclass = new DriveClass();
            myClass myclass = driveclass;
            myclass.ID = "234324";
            myclass.Name = "sdfsdf";
            myclass.ShowInfo();
            Console.ReadLine();
        }
    }
}
