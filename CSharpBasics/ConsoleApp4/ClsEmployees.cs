using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics.ConsoleApp4
{
    public class ClsEmployees
    {

        public ClsEmployees()
        {
            Name = "";
            DailySalary = 0.0m;
            Age = 0;
        }

        private string _Name;

        public int Age { get; set; }

        public string Name { get => _Name; set => _Name = value; }

        public decimal DailySalary { get; set; }

        public decimal CalculateSalary(int NumOfDays)
        {
            return DailySalary * NumOfDays;
        }
    }
}
