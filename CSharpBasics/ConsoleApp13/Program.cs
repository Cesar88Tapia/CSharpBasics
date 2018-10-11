using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics.ConsoleApp13
{
    class Program
    {
        public static void Main()
        {

            ConsoleApp13.ConsoleApp13 v13 = new ConsoleApp13.ConsoleApp13();
            v13.Execute();

            Customr customer1 = new Customr()
            {
                ID = 101,
                Name = "Cesar",
                Salary = 5000
            };

            Customr customer2 = new Customr()
            {
                ID = 110,
                Name = "Pam",
                Salary = 5000
            };

            Customr customer3 = new Customr()
            {
                ID = 119,
                Name = "John",
                Salary = 6500
            };

            Dictionary<int, Customr> dictionaryCustomers = new Dictionary<int, Customr>();
            dictionaryCustomers.Add(customer1.ID, customer1);
            dictionaryCustomers.Add(customer2.ID, customer2);
            dictionaryCustomers.Add(customer3.ID, customer3);

            if (dictionaryCustomers.ContainsKey(135))
            {
                Customr cust = dictionaryCustomers[135];
            }
            Console.ReadKey();
        }
    }

    public class Customr
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}
