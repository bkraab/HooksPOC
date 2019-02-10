using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eai.Cds.Poc.VMs
{
    public class HookMeta
    {
        public HookMeta()
        {
            //this.prefetch = new List<string>(0);
        }
        public string hook { get; set; }
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public ExpandoObject prefetch { get; set; }
        //public List<string> prefetch { get; set; }
    }
}
