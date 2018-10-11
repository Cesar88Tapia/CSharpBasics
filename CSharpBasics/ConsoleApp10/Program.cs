using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics.ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {

            ConsoleApp10.ConsoleApp10 v10 = new ConsoleApp10.ConsoleApp10();
            v10.Execute();

            clsMatrices Matrix;
            Matrix = new clsMatrices();
            Matrix.InitMatrix();
            Matrix.PrintMatrix();
        }
    }
}
