using System;
using System.IO;

namespace ConsoleApplication1
{
    internal class Program
    {
        private static FileStream _fs;
        private static StreamWriter _sw;

        public delegate void PrintString(string s);

        public static void WriteToScreen(string str)
        {
            Console.WriteLine("The String is: {0}", str);
        }

        public static void WriteToFile(string s)
        {
            _fs = new FileStream("H:\\message.txt", FileMode.Append, FileAccess.Write);
            _sw = new StreamWriter(_fs);
            _sw.WriteLine(s);
            _sw.Flush();
            _sw.Close();
            _fs.Close();
        }
        public static void SendString(PrintString ps)
        {
            ps("Hello World");
        }

        private static void Main()
        {
            var ps1 = new PrintString(WriteToScreen);
            var ps2 = new PrintString(WriteToFile);
            SendString(ps1);
            SendString(ps2);
            Console.ReadKey();
        }
    }
}
