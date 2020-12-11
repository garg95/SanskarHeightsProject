using Models;
using System.Collections.Generic;
using System.Linq;

namespace DataLayers
{
    public class StudentData:IStudentData
    {
        private EmployeeContext employeeContext;
        public StudentData()
        {
            employeeContext = new EmployeeContext();
        }
        public IEnumerable<Student> GetStudentClassWise(int standardid)
        {
            return employeeContext.students.Where(x => x.Standard == standardid).ToList();
        }
    }
}
