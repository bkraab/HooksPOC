using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eai.Cds.Poc.VMs.stu3
{
    public class HookRequestVM
    {
        public string hookInstance { get; set; }
        public string hook { get; set; }
        public string fhirServer { get; set; }
        public string user { get; set; }
        public string patient { get; set; }
        public ContextVM context { get; set; }

        public PrefetchVM prefetch { get; set; }
    }
}

