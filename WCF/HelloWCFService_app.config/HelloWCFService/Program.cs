using System;
using System.ServiceModel;

namespace HelloWCFService
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(HelloWCFService));

            host.Open();
            Console.WriteLine("Service is Ready");
            Console.WriteLine("Press Any Key to Terminated...");
            Console.ReadLine();

            host.Close();
        }
    }

    [ServiceContract]
    interface IHelloWCFService
    {
        [OperationContract]
        string HelloWCF();
    }

    public class HelloWCFService : IHelloWCFService
    {
        public string HelloWCF()
        {
            return "Hello WCF!";
        }
    }
}
