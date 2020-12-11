using DataLayers;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class StudentLogic:IStudentLogic
    {
        private IStudentData _studentData;
        public StudentLogic(IStudentData studentData)
        {
            _studentData = studentData;
        }
        public IEnumerable<Student> GetStudentClassWise(int standardid)
        {
            return _studentData.GetStudentClassWise(standardid);
        }
    }
}
