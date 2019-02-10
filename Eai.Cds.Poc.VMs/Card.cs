using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eai.Cds.Poc.VMs
{
    public class Card
    {
        public Card()
        {
            this.links = new List<LinkVM>(0);
        }
        public string summary { get; set; }
        public string indicator { get; set; }
        public Source source { get; set; }
        public List<LinkVM> links { get; set; }
    }
}
