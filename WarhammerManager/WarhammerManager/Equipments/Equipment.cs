using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarhammerManager.Rules;

namespace WarhammerManager.Equipments
{
    public abstract class Equipment : IRulable
    {
        public string EquipmentName;
        List<Rule> rulesApplied;
        internal List<Rule> RulesApplied
        {
            get { return rulesApplied; }
            set { rulesApplied = value; }
        }

        public int AttackStat { get; internal set; }

        public int DefenseStat { get; internal set; }

        public Equipment(string equipmentName, int attackStat, int defenseStat)
        {
            rulesApplied = new List<Rule>();
            EquipmentName = equipmentName;
            AttackStat = attackStat;
            DefenseStat = defenseStat;
        }

        public override string ToString()
        {
            return EquipmentName;
        }

        public void AddRules(Rule rule)
        {
            if (rulesApplied.Contains(rule))
            {
                Console.WriteLine("This rule has already been applied to this equipment.");
            }
            else
            {
                rule.ApplyRuleToEquipment(this);
            }
        }

        public void DeleteRules(Rule rule)
        {
            if (rulesApplied.Contains(rule))
            {
                rule.RemoveRuleToEquipment(this);
            }
            else
            {
                Console.WriteLine("This rule isn't applied to this troop.");
            }
        }      
    }
}
