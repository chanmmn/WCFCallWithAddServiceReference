using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ConAppWCFNoProxyClient
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicHttpBinding binding = new BasicHttpBinding();

            //Create EndPoint address  
            EndpointAddress endpointAddress = new EndpointAddress("http://localhost:50960/Service1.svc");

            //Pass Binding and EndPoint address to ChannelFactory  
            ChannelFactory<IService1> factory = new ChannelFactory<IService1>(binding, endpointAddress);

            //Now create the new channel as below  
            IService1 channel = factory.CreateChannel();

            //Call the service method on this channel as below  
            string result = channel.GetData(1);
        }
    }
}
