using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarhammerManager.Equipments
{
    public class Weapon: Equipment
    {
        public Weapon(string weaponName, int attack) : base(weaponName, attack, 0)
        { }
        
        public override string ToString()
        {
            return base.ToString() + " attack bonus : " + AttackStat;
        }
    }
}
