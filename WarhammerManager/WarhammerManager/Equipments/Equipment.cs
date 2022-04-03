using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarhammerManager.Equipments
{
    abstract class Equipment
    {
        string equipmentName;

        public Equipment(string _equipmentName)
        {
            equipmentName = _equipmentName;
        }
    }
}
