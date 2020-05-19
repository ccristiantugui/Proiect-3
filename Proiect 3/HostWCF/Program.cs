using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;

using ObjectWCF;

namespace HostWCF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Launching WCF server...");

            ServiceHost host = new ServiceHost(typeof(MediaManager), new Uri("http://localhost:8000/PC"));
            foreach (ServiceEndpoint se in host.Description.Endpoints)
            {
                Console.WriteLine("A (address): {0} \nB (binding): {1} \nC (contract): {2}",
                    se.Address, se.Binding.Name, se.Contract.Name);
            }

            try
            {
                host.Open();
                Console.WriteLine("Server launched. Waiting for connections...");
                Console.WriteLine("Press Enter to stop the server");
                Console.ReadLine();
                host.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("The server could not be started.");
                Console.WriteLine(e);
            }
        }
    }
}
