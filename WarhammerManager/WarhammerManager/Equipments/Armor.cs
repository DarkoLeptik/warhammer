using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarhammerManager.Equipments
{
    class Armor: Equipment
    {
        int armor;

        public Armor(string _armorName, int _armor) : base(_armorName)
        {
            armor = _armor;
        }
    }
}
