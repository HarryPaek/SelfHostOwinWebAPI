using Microsoft.Owin.Hosting;
using SelfHostOWIN.Common.Utilities;
using System;

namespace SelfHostOWIN.WEBAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceAddress = Configurations.GetServiceAddress();

            Console.WriteLine(" Service is starting at {0}", serviceAddress);
            Console.WriteLine(" ..... ..... .....");

            using (WebApp.Start<Startup>(Configurations.GetServiceAddress()))
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine(" Service was  started at {0}", serviceAddress);
                Console.WriteLine(" Please press <ENTER> to QUIT the Service...");

                Console.ReadLine();
            }
        }
    }
}
