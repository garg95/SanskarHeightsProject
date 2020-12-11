using DataLayers;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class StandardLogic : IStandardLogic
    {
        private IStandardData _standardData;
        public StandardLogic(IStandardData standardData)
        {
            _standardData = standardData;
        }
        public IEnumerable<Standard> GetStandards()
        {
            return _standardData.GetStandards();
        }
    }
}
