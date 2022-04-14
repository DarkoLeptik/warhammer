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

        }

        public void DeleteRules(Rule rule)
        {

        }

        public List<Rule> getRulesApplied()
        {
            return rulesApplied;
        }
    }
}
