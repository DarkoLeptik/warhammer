using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarhammerManager.Equipments
{
    class Weapon: Equipment
    {
        int attack;

        public Weapon(string _weaponName, int _attack) : base(_weaponName)
        {
            attack = _attack;
        }
    }
}
