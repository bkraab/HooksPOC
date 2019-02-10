using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Routing;

using Eai.Cds.Poc.VMs;
using Eai.Cds.Poc.VMs.stu3;
using Eai.Cds.Poc.Services;

namespace Eai.Cds.Poc.WebApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "GET, POST, OPTIONS")]
    [Route("cds-services")]
    public class CdsServicesController : ApiController
    {        
        //public IEnumerable<Object> Get()
        public IHttpActionResult Get()
        {
            CdsServices cdsSvc = new CdsServices();
            List<HookMeta> ret = cdsSvc.GetServices();
            return Ok(new { services = ret });            
        }


        //[Route("patient-view-example")]
        [HttpPost]
        [Route("cds-services/patient-view-example")]
        public Object PostPatientView([FromBody]HookRequestVM hookInstance)
        {
            CdsServices cdsSvc = new CdsServices();
            List<Card> cards = cdsSvc.GetPatientViewInsights(hookInstance);           
            return new { cards = cards };
        }

        //[Route("patient-view-example")]
        [HttpPost]
        [Route("cds-services/medication-prescribe-example")]
        public Object Post([FromBody]Object hookInstance)
        {
            CdsServices cdsSvc = new CdsServices();
            List<Card> cards = cdsSvc.GetMedicationPrescribeInsights();
            return new { cards = cards };            
        }
    }       
}
