using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eai.Cds.Poc.VMs.stu3
{
    public class AddressVM
    {
        public AddressVM()
        {
            line = new List<string>(0);
        }

        public string use { get; set; }
        public List<string> line { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string postalCode { get; set; }
        public string country { get; set; }
    }
}
