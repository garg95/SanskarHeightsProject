using Models;
using System.Collections.Generic;
using System.Linq;


namespace DataLayers
{
    public class StandardData:IStandardData
    {
        EmployeeContext employeeContext;
        public StandardData()
        {
            employeeContext = new EmployeeContext();
        }
        public IEnumerable<Standard> GetStandards()
        {
            return employeeContext.standards.ToList();
        }
    }
}
