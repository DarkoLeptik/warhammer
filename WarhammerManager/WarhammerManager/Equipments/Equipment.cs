using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarhammerManager.Rules;

namespace WarhammerManager.Equipments
{
    abstract class Equipment : Rulable
    {
        string equipmentName;
        List<Rule> rulesApplied;

        public Equipment(string _equipmentName)
        {
            rulesApplied = new List<Rule>();
            equipmentName = _equipmentName;
        }
        
        public void AddRules(Rule rule)
        {
            if (rulesApplied.Contains(rule))
            {
                Console.WriteLine("Cette règle est déjà appliquée à cet équipement");
            }
            else
            {
                rule.Apply();
            }
        }

        public void DeleteRules(Rule rule)
        {
            if (rulesApplied.Contains(rule))
            {
                rule.Remove();
            }
            else
            {
                Console.WriteLine("Cette règle n'est pas appliquée à cet équipement");
            }
        }

        public List<Rule> getRulesApplied()
        {
            return rulesApplied;
        }
    }
}
