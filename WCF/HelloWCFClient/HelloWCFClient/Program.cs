using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HelloWCFClient.MyService;

namespace HelloWCFClient
{
    class Program
    {
        static void Main(string[] args)
        {
            MyService.HelloWCFServiceClient client = new HelloWCFServiceClient();
            string strRet = client.HelloWCF();

            Console.WriteLine(strRet);
            Console.ReadLine();

            client.Close();
        }
    }
}
