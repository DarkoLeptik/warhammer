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
        
        public void AddRules(Rule rule)
        {
            if (rulesApplied.Contains(rule))
            {
                Console.WriteLine("Cette règle est déjà appliquée à cet équipement");
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
                Console.WriteLine("Cette règle n'est pas appliquée à cet équipement");
            }
        }      
    }
}
