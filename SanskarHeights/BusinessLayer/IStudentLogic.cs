using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public interface IStudentLogic
    {
        IEnumerable<Student> GetStudentClassWise(int standardid);
    }
}
