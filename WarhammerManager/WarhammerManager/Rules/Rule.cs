using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarhammerManager.Equipments;

namespace WarhammerManager.Rules
{
    public class Rule
    {
        private int attackBonus;
        private int defenseBonus;
        public Rule(int _attackBonus, int _defenseBonus)
        {
            attackBonus = _attackBonus;
            defenseBonus = _defenseBonus;
        }

        public void ApplyRuleToTroop()
        {

        }

        public void RemoveRuleToTroop()
        {

        }

        public void ApplyRuleToEquipment(Equipment equipment)
        {
            equipment.AttackStat += attackBonus;
            equipment.DefenseStat += defenseBonus;
            equipment.RulesApplied.Add(this);
        }

        public void RemoveRuleToEquipment(Equipment equipment)
        {
            //Appliquer changements
            equipment.AttackStat -= attackBonus;
            equipment.DefenseStat -= defenseBonus;
            equipment.RulesApplied.Remove(this);
        }
    }
}
