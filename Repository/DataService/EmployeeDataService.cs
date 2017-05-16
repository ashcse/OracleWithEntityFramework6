using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.DataService
{
    public class EmployeeDataService : IEmployeeDataService
    {
        public async Task<List<EMPLOYEE>> GetEmployeesAsync()
        {
            List<EMPLOYEE> result = null;
            using (CDEntities db = new CDEntities())
            {
                result = await db.EMPLOYEES.ToListAsync();
            }

            return result;
        }
    }
}
