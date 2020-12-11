using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayers
{
    public interface IStudentData
    {
        IEnumerable<Student> GetStudentClassWise(int standardid);
    }
}
