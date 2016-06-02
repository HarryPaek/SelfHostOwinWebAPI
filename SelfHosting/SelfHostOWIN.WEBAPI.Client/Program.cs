using SelfHostOWIN.Common.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SelfHostOWIN.WEBAPI.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Create HttpCient and make a request to api/values 
                HttpClient client = new HttpClient();

                var response = client.GetAsync(Configurations.GetServiceAddress() + "values").Result;

                Console.WriteLine(response);
                Console.WriteLine(response.Content.ReadAsStringAsync().Result);

                Console.WriteLine(" Please press <ENTER> to QUIT...");

                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
