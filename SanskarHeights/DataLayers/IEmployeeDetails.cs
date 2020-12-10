using DataLayers.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayers
{
    public interface IEmployeeDetails
    {
        Models.Employee GetEmployee(string firstName,string password);
    }
}
