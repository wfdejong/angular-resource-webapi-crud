using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using AngularTutorial.Models;

namespace AngularTutorial.Controllers
{
    public class SuitcaseApiController : ApiController
    {
        public IHttpActionResult Get(int id)
        {
            return Ok(Singleton.Instance.Suitcases.Single(s => s.Id == id));
        }

        public IHttpActionResult Get()
        {
            if (Singleton.Instance.Suitcases == null)
            {
                List<Suitcase> suitcases = new List<Suitcase>
                {
                    new Suitcase {Id = 1, Locked = true, Wheels = 4},
                    new Suitcase {Id = 2, Locked = false, Wheels = 2}
                };

                Singleton.Instance.Suitcases = suitcases;
            }

            return Ok(Singleton.Instance.Suitcases);
        }

        public void Post(Suitcase suitcase)
        {
            var lastsuitcase = Singleton.Instance.Suitcases.LastOrDefault();
            if (lastsuitcase != null)
                suitcase.Id = lastsuitcase.Id + 1;

            Singleton.Instance.Suitcases.Add(suitcase);
        }

        public void Put(Suitcase suitcase)
        {
            Suitcase oldSuitcase = Singleton.Instance.Suitcases.Single(s => s.Id == suitcase.Id);
            oldSuitcase.Locked = suitcase.Locked;
            oldSuitcase.Wheels = suitcase.Wheels;
        }
        
        [HttpDelete]
        public HttpResponseMessage Delete(int id)
        {
            Singleton.Instance.Suitcases.RemoveAll(p => p.Id == id);
            return Request.CreateResponse(HttpStatusCode.OK, "The customer was deleted.");
        }        
    }
}
