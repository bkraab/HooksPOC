using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eai.Cds.Poc.VMs.stu3
{
    public class IndentifierVM
    {
        public IndentifierVM()
        {
            
        }
        public string use { get; set; }
        
        public IdentifierTypeVM type { get; set; }
        
        public string system { get; set; }
        //public string a { get; set; }
        public string value { get; set; }
    }
}
