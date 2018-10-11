using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics.ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Array = new int[12];
            int i;
            string Chain;
            for (i = 0; i < 12; i++)
            {
                Chain = Console.ReadLine();
                Array[i] = Convert.ToInt32(Chain);
            }
            for (i = 0; i < 12; i++)
            {
                Console.WriteLine("{0}", Array[i]);
            }
            Console.ReadKey();
        }
    }
}
