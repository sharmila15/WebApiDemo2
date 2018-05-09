using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestServices.Models
{
    public class Employees
    {
        public int Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String address { get; set; }
        public String phnNumber { get; set; }
        public String Gender { get; set; }
        
    }
}