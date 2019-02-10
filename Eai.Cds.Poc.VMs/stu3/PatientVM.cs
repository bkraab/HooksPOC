using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eai.Cds.Poc.VMs.stu3
{
    public class PatientVM
    {
        public PatientVM()
        {
            this.name = new List<NameVM>(0);
            this.telecom = new List<TelecomVM>(0);
        }
        public string resourceType { get; set; }
        public string id { get; set; }
        public MetaVM meta  { get; set; }
        public TextVM text { get; set; }
        public List<IndentifierVM> identifier { get; set; }
        public string active { get; set; }
        public List<NameVM> name { get; set; }
        public List<TelecomVM> telecom { get; set; }
        public string gender { get; set; }
        public string birthDate { get; set; }
        public List<AddressVM> address { get; set; }
    }
}
