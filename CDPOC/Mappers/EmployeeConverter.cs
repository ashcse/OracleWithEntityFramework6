using CDPOC.Models;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CDPOC.Mappers
{
    /// <summary>
    /// Covnerts DB entity EMPLOYEE to POCO model Employee
    /// </summary>
    public class EmployeeConverter : IConverter<EMPLOYEE, Employee>
    {
        public IEnumerable<Employee> Convert(IEnumerable<EMPLOYEE> sourceColl)
        {
            IList<Employee> resultList = new List<Employee>();
            foreach(var emp in sourceColl)
            {
                resultList.Add(new Employee
                {
                    DEPARTMENT_ID = emp.DEPARTMENT_ID,
                    Email = emp.EMAIL,
                    EmployeeId = emp.EMPLOYEE_ID,
                    FirstName = emp.FIRST_NAME,
                    LastName = emp.LAST_NAME,
                    MANAGER_ID = emp.MANAGER_ID,
                    SALARY = emp.SALARY
                });                
            }

            return resultList;
        }

        public Employee Convert(EMPLOYEE sourceType)
        {
            return new Employee
            {
                Email = sourceType.EMAIL,
                DEPARTMENT_ID = sourceType.DEPARTMENT_ID,
                EmployeeId = sourceType.EMPLOYEE_ID,
                FirstName = sourceType.FIRST_NAME,
                LastName = sourceType.LAST_NAME,
                MANAGER_ID = sourceType.MANAGER_ID,
                SALARY = sourceType.SALARY
            };
        }
    }
}