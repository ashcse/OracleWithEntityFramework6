using CDPOC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDPOC.ApplicationService
{
    public interface IApplicationService
    {
        Task<List<Employee>> GetEmployeesAsync();

        Task<Employee> GetEmployeeAsync(int? id);

        Task AddEmployeeAsync(Employee employee);

        Task UpdateAsync(Employee employee);

        Task DeleteEmployeeAsync(int id);
    }
}
