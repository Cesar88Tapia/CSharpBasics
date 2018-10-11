using System.IO;

namespace CSharpBasics.ConsoleApp7
{
    internal class clsFiles : intExits
    {
        public void PrintClient(clsAbsClients client)
        {
            StreamWriter ar = new StreamWriter(@"C:\Users\Cesar\source\repos\ConsoleApp7\FileBinnacle.log", true);
            ar.WriteLine(client.Pin + " " + client.Name);
            if (client.RegimentType == 1)
                ar.WriteLine("Type: Physical Person");
            else
                ar.WriteLine("Type: Morar Person");
            ar.WriteLine("RFC: " + client.RFC);
            ar.Close();
        }

        public void PrintAddress(clsAddresses address)
        {
            StreamWriter ar = new StreamWriter(@"C:\Users\Cesar\source\repos\ConsoleApp7\FileBinnacle.log", true);
            ar.Close();
        }
    }
}