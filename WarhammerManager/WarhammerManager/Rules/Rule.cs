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
        private int _attackBonus;
        private int _defenseBonus;
        internal readonly string RuleName;
        
        internal Rule(int attackBonus, int defenseBonus, string ruleName)
        {
            _attackBonus = attackBonus;
            _defenseBonus = defenseBonus;
            RuleName = ruleName;
        }

        internal void ApplyRuleToTroop<T1, T2>(Troop<T1,T2> troop) where T1 : Army where T2 : Squad<T1>
        {
            troop.Attack += _attackBonus;
            troop.Armor += _defenseBonus;
            troop.RulesApplied.Add(this);
        }

        internal void RemoveRuleToTroop<T1,T2>(Troop<T1, T2> troop) where T1 : Army where T2 : Squad<T1>
        {
            troop.Attack -= _attackBonus;
            troop.Armor -= _defenseBonus;
            troop.RulesApplied.Remove(this);
        }

        internal void ApplyRuleToEquipment(Equipment equipment)
        {
            equipment.AttackStat += _attackBonus;
            equipment.DefenseStat += _defenseBonus;
            equipment.RulesApplied.Add(this);
        }

        internal void RemoveRuleToEquipment(Equipment equipment)
        {
            //Appliquer changements
            equipment.AttackStat -= _attackBonus;
            equipment.DefenseStat -= _defenseBonus;
            equipment.RulesApplied.Remove(this);
        }

        public override string ToString()
        {
            return RuleName + " attack bonus: " + _attackBonus + " defense bonus " + _defenseBonus;
        }
    }
}
