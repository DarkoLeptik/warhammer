using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarhammerManager.Equipments
{
    public class Armor: Equipment
    {

        public Armor(string _armorName, int _armor) : base(_armorName, 0, _armor)
        {
        }
    }
}
