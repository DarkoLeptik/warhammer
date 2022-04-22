using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarhammerManager.Rules;

namespace WarhammerManager.Equipments
{
    public abstract class Equipment : Rulable
    {
        public string equipmentName;
        List<Rule> rulesApplied;
        public List<Rule> RulesApplied
        {
            get { return rulesApplied; }
            set { rulesApplied = value; }
        }

        public int AttackStat { get; internal set; }

        public int DefenseStat { get; internal set; }

        public Equipment(string _equipmentName, int _attackStat, int _defenseStat)
        {
            rulesApplied = new List<Rule>();
            equipmentName = _equipmentName;
            AttackStat = _attackStat;
            DefenseStat = _defenseStat;
        }

        void Rulable.AddRules(Rule rule)
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

        void Rulable.DeleteRules(Rule rule)
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
