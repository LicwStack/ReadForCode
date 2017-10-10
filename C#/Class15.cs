using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    interface ImyInterface1
    {
        int Add();
    }

    interface ImyInterface2
    {
        int Add();
    }

    class Program:ImyInterface1,ImyInterface2
    {
        int ImyInterface1.Add()
        {
            int x = 3;
            int y = 5;
            return x + y;
        }
        int ImyInterface2.Add()
        {
            int x = 3;
            int y = 5;
            int z = 7;
            return x + y + z;
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            ImyInterface1 imyinterface1 = program;
            Console.WriteLine(imyinterface1.Add());
            ImyInterface2 imyinterface2 = program;
            Console.WriteLine(imyinterface2.Add());
            Console.ReadLine();
        }
    }
}
