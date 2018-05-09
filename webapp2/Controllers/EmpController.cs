using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using webapp2.Models;


namespace webapp2.Controllers
{
    public class EmpController : ApiController
    {
        // GET: api/Emp
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Emp/5
        public IHttpActionResult GetById(int id)
        {
            Empl e = new Empl();

            var myObjectResponse = GetObjectFromDb(id);

        }

        // POST: api/Emp
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Emp/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Emp/5
        public void Delete(int id)
        {
        }
    }
}
