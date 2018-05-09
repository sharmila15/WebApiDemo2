using EmpDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiDemo2.Controllers
{
    public class EmployeeController : ApiController
    {
        [HttpGet]
        public IEnumerable<spGetEmployeesByLastName_Result> GetByLn(string term)
        {
            using (CompanyEntities entities = new CompanyEntities())
            {

                return entities.spGetEmployeesByLastName(term);
                //return entities.Employees.FirstOrDefault(e => e.EmpLn == term);
            }
        }
    }
}
