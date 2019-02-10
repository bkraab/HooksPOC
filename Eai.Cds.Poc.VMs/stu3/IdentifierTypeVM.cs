using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eai.Cds.Poc.VMs.stu3
{
    public class IdentifierTypeVM
    {
        public IdentifierTypeVM()
        {
            this.coding = new List<CodingVM>(0);
        }
        public List<CodingVM> coding { get; set; }
        public string text { get; set; }
    }
}
