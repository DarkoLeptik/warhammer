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
        string equipmentName;
        List<Rule> rulesApplied;
        public List<Rule> RulesApplied
        {
            get { return rulesApplied; }
            set { rulesApplied = value; }
        }
        int attackStat;
        public int AttackStat
        {
            get { return attackStat; }
            set { attackStat = value; }
        }
        int defenseStat;
        public int DefenseStat
        {
            get { return defenseStat; }
            set { defenseStat = value; }
        }

        public Equipment(string _equipmentName, int _attackStat, int _defenseStat)
        {
            rulesApplied = new List<Rule>();
            equipmentName = _equipmentName;
            attackStat = _attackStat;
            defenseStat = _defenseStat;
        }
        
        public void AddRules(Rule rule)
        {
            if (rulesApplied.Contains(rule))
            {
                Console.WriteLine("Cette règle est déjà appliquée à cet équipement");
            }
            else
            {
                rule.Apply(this);
            }
        }

        public void DeleteRules(Rule rule)
        {
            if (rulesApplied.Contains(rule))
            {
                rule.Remove(this);
            }
            else
            {
                Console.WriteLine("Cette règle n'est pas appliquée à cet équipement");
            }
        }      
    }
}
