using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics.ConsoleApp6
{
    public class ClsClients
    {
        private int clientId;

        private string _Names;

        private string _LastName;

        public int ClientId { get => clientId; set => clientId = value; }
        public string Names { get => _Names; set => _Names = value; }
        public string LastName { get => _LastName; set => _LastName = value; }
    }
}
