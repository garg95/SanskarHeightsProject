using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.ServiceModels;
using DataLayers;

namespace BusinessLayer
{
    public class EmployeeLogic : IEmployeeLogic
    {
        private IEmployeeDetails _employeeDetails;
        public EmployeeLogic(IEmployeeDetails employeeDetails)
        {
            _employeeDetails = employeeDetails;
        }
        public bool CheckEmployee(string firstName,string password)
        {
            Models.Employee employee= _employeeDetails.GetEmployee(firstName, password);
            return _employeeDetails.GetEmployee(firstName, password)==null?false:true;
        }
    }
}
