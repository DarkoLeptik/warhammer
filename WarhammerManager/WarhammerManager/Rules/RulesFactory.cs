using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarhammerManager.Rules
{
    public class RulesFactory
    {
        public List<Rule> rules;

        private static RulesFactory? instance;

        public static RulesFactory Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new RulesFactory();
                }
                return instance;
            }
        }

        private RulesFactory()
        {
            rules = new List<Rule>();
            Console.WriteLine("I am an instance of rulefactory !");
        }

        public int CreateRule(int attackBonus, int defenseBonus)
        {
            Rule newRule = new Rule(attackBonus, defenseBonus);
            
            rules.Add(newRule);

            return rules.IndexOf(newRule);
        }

        public void ApplyRule(Rulable objectToRule, int ruleIndex)
        {
            objectToRule.AddRules(rules[ruleIndex]);
        }
        
        public void RemoveRule(Rulable objectToRule, int ruleIndex)
        {
            objectToRule.DeleteRules(rules[ruleIndex]);
        }

        public string ListOfRules()
        {
            string myRules = "### Existing Rules ###\n";
            foreach (var rule in rules)
            {
                myRules += "[" + rules.IndexOf(rule) + "] "+ rule.ToString() + "\n";
            }

            return myRules;
        }
    }
}
