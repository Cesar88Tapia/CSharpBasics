using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics.ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            ClsEmployees employee;
            employee = new ClsEmployees();
            employee.Age = 35;
            employee.Name = "Cesar Tapia";
            employee.DailySalary = 12.5m;
            decimal total;
            total = employee.CalculateSalary(30);
            Console.WriteLine("Employee´s monthly salary " + employee.Name);
            Console.WriteLine("is: " + total.ToString("c"));
            Console.ReadKey();
        }
    }
}
