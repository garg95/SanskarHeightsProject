using BusinessLayer.ServiceModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public interface IEmployeeLogic
    {
        bool CheckEmployee(string firstName,string password);
    }
}
