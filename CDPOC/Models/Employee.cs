using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CDPOC.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Nullable<decimal> SALARY { get; set; }
        public Nullable<int> MANAGER_ID { get; set; }
        public Nullable<short> DEPARTMENT_ID { get; set; }
    }
}