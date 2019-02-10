using System.Collections.Generic;
using System.Data.Entity;
using System.Dynamic;
using System.Linq;

using Eai.Cds.Poc.VMs;
using Eai.Cds.Poc.VMs.stu3;


namespace Eai.Cds.Poc.Services
{
    public class CdsServices
    {

        public List<HookMeta> GetServices()
        {
            List<CdsServiceConfig> hooks = new List<CdsServiceConfig>(0);

            using (EaiDBEntities ctx = new EaiDBEntities())
            {
                //hooks = ctx.CdsServiceConfig.Include().ToList();
                hooks = (from s in ctx.CdsServiceConfig
                         select s).Include(x => x.CdsServicePrefetch)
                                  .ToList();
            }

            List<HookMeta> ret = new List<HookMeta>(0);

            foreach (CdsServiceConfig aHook in hooks)
            {
                HookMeta meta = new HookMeta();
                meta.hook = aHook.Hook;
                meta.title = aHook.Title;
                meta.description = aHook.Description;
                meta.id = aHook.Id;

                if (aHook.CdsServicePrefetch != null && aHook.CdsServicePrefetch.Count > 0)
                {
                    meta.prefetch = GetPrefetchList(aHook.CdsServicePrefetch.ToList());
                }

                ret.Add(meta);
            }

            return ret;

        }

        private ExpandoObject GetPrefetchList(List<CdsServicePrefetch> prefetches)
        {

            dynamic testDyn = new ExpandoObject();
            IDictionary<string, object> disct = (IDictionary<string, object>)testDyn;
            
            foreach(CdsServicePrefetch pre in prefetches)
            {
                disct.Add(pre.resourceName, pre.resourceString);                
            }

            return testDyn;
        }

        public List<Card> GetPatientViewInsights(HookRequestVM hookRequest)
        {
            HookRequestVM vm = (HookRequestVM)hookRequest;

            List<Card> cards = new List<Card>(0);

            using (EaiDBEntities ctx = new EaiDBEntities())
            {
                List<Insight> insights = (from s in ctx.Insight
                                          select s).Include(x => x.InsightLink)
                                                   .ToList();
                foreach(Insight site in insights)
                {
                    Card c2 = new Card();
                    c2.summary = site.ProviderMessageheadline;
                    c2.indicator = "info";

                    List<LinkVM> vms = new List<LinkVM>(0);
                    foreach (InsightLink aLink in site.InsightLink.ToList())
                    {
                        LinkVM lvm = new LinkVM();
                        lvm.label = aLink.LinkLabel;
                        lvm.type = aLink.Vv_LinkType;
                        lvm.url = aLink.LinkUrl;
                        vms.Add(lvm);
                    }

                    if(vms.Count > 0)
                    {
                        c2.links = vms;
                    }

                    cards.Add(c2);

                }
            }

            return cards;            
        }

        public List<Card> GetMedicationPrescribeInsights()
        {
            List<Card> cards = new List<Card>(0);
            Card c = new Card();
            //c.summary = "Reduce cardiovascular risks, prescribe daily 81 MG Aspirin";
            c.summary = "Calcium Intake Advisory(Women ages 25 - 50)";
            c.indicator = "warning";
            cards.Add(c);

            return cards;
        }
    }
}
