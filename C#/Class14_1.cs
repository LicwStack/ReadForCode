using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    interface IPeople
    {
        string Sex
        {
            get;
            set;
        }
        string Name
        {
            get;
            set;
        }
    }

    interface ITeacher : IPeople
    {
        void teach();
    }

    interface IStudent : IPeople 
    {
        void study();
    }

    class Program:IPeople,ITeacher,IStudent
    {
        string sex = "";
        string name = "";
        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public void teach()
        {
            Console.WriteLine(Name + " " + Sex + " Teacher");
        }
        public void study()
        {
            Console.WriteLine(Name + " " + Sex + " Student");
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            ITeacher iteacher = program;
            iteacher.Sex = "Male";
            iteacher.Name = "66666";
            iteacher.teach();
            Program program1 = new Program();
            IStudent istudent = program1;
            istudent.Sex = "Male";
            istudent.Name = "23333";
            istudent.study();
            Console.ReadLine();
        }
    }
}
