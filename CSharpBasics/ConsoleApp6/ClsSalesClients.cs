using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics.ConsoleApp6
{
    public class ClsSalesClients : ClsClients
    {
        private string _RFC;

        private string _Address;

        private string _City;

        private string _State;

        private bool _IsCredit;

        public string RFC { get => _RFC; set => _RFC = value; }
        public string Address { get => _Address; set => _Address = value; }
        public string City { get => _City; set => _City = value; }
        public string State { get => _State; set => _State = value; }
        public bool IsCredit { get => _IsCredit; set => _IsCredit = value; }
    }
}
