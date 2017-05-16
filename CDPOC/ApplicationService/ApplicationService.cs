using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using CDPOC.Models;
using Repository.DataService;

namespace CDPOC.ApplicationService
{
    public class ApplicationService : IApplicationService
    {
        IEmployeeDataService employeeDataService = null;       

        public ApplicationService(IEmployeeDataService employeeDataService)
        {
            this.employeeDataService = employeeDataService;
        }


        public Task AddEmployeeAsync(Employee employee)
        {
            throw new NotImplementedException();
        }

        public Task DeleteEmployeeAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Employee> GetEmployeeAsync(int? id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Employee>> GetEmployeesAsync()
        {
            var query = await employeeDataService.GetEmployeesAsync();

            List<Employee> result = new List<Employee>();
            foreach(var emp in query)
            {
               result.Add( new Employee
                {
                    DEPARTMENT_ID = emp.DEPARTMENT_ID,
                    Email = emp.EMAIL,
                    FirstName = emp.FIRST_NAME,
                    EmployeeId = emp.EMPLOYEE_ID,
                    LastName = emp.LAST_NAME,
                    MANAGER_ID = emp.MANAGER_ID,
                    SALARY = emp.SALARY

                });
            }

            return result;

        }

        public Task UpdateAsync(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}