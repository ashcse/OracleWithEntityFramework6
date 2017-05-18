using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using CDPOC.Models;
using Repository.DataService;
using CDPOC.Mappers;

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
            return (new EmployeeConverter()).Convert(query).ToList();
        }

        public Task UpdateAsync(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}