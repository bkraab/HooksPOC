using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eai.Cds.Poc.VMs.stu3
{
    public class NameVM
    {
        public NameVM()
        {
            this.family = new List<string>(0);
            this.given = new List<string>(0);
        }
        public string use { get; set; }
        public List<string> family { get; set; }
        public List<string> given { get; set; }
    }
}
