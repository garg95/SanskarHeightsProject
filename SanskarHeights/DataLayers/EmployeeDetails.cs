using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayers
{
    public class EmployeeDetails : IEmployeeDetails
    {
        EmployeeContext employeeContext = new EmployeeContext();
        public Models.Employee GetEmployee(string firstName,string password)
        {
            return employeeContext.employees.Where(x => x.FirstName == firstName && x.Password == password).FirstOrDefault();
        }
    }
}
