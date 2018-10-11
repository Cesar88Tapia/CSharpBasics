using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics.ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            ClsSalesClients Client;
            Client = new ClsSalesClients();
            Client.ClientId = 123;
            Client.LastName = "Tapia Martinez";
            Client.Names = "Cesar Felipe";
            Client.RFC = "TAMC040789";
            Client.Address = "123 West Ave.";
            Client.City = "North Hills";
            Client.State = "California";
            Client.IsCredit = true;
            Console.WriteLine(Client.LastName + " " + Client.Names);
            Console.WriteLine(Client.Address + " " + Client.City + " " + Client.State);
            Console.WriteLine(Client.RFC);
            if (Client.IsCredit)
                Console.WriteLine("The client has a credit");
            else
                Console.WriteLine("The client has no credit");
            Console.ReadKey();
        }
    }
}
