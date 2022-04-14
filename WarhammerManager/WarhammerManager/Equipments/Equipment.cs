using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarhammerManager.Rules;

namespace WarhammerManager.Equipments
{
    abstract class Equipment : Rulable
    {
        string equipmentName;

        public Equipment(string _equipmentName)
        {
            equipmentName = _equipmentName;
        }
    }
}
