using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace HelloWCFClient
{
    class Program
    {
        static void Main(string[] args)
        {
            EndpointAddress address = new EndpointAddress("http://localhost/IISService/HelloWCFService.svc");
            WSHttpBinding binding = new WSHttpBinding();

            ChannelFactory<IHelloWCFChannel> factory = new ChannelFactory<IHelloWCFChannel>(binding, address);
            
            IHelloWCFChannel channel = factory.CreateChannel();

            string result = channel.HelloWCF();

            channel.Close();

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }

    [ServiceContract]
    public interface IHelloWCF
    {
        [OperationContract]
        string HelloWCF();
    }

    public interface IHelloWCFChannel : IHelloWCF, IClientChannel
    {
    }
}
