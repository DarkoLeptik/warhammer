using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarhammerManager.Equipments
{
    public class Weapon: Equipment
    {
        public int Range { get; internal set; }
        
        public Weapon(string _weaponName, int _attack, int range) : base(_weaponName, _attack, 0)
        {
            Range = range;
        }
    }
}
