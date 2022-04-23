using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarhammerManager.Rules
{
    public class RulesFactory
    {
        internal List<Rule> rules;

        private static RulesFactory? _instance;

        public static RulesFactory Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new RulesFactory();
                }
                return _instance;
            }
        }

        private RulesFactory()
        {
            rules = new List<Rule>();
            Console.WriteLine("I am an instance of rulefactory !");
        }

        public int CreateRule(int attackBonus, int defenseBonus, string ruleName)
        {
            Rule newRule = new Rule(attackBonus, defenseBonus, ruleName);
            
            rules.Add(newRule);

            return rules.IndexOf(newRule);
        }

        public bool ApplyRule(IRulable objectToRule, int ruleIndex)
        {
            if (ruleIndex < rules.Count)
            {
                objectToRule.AddRules(rules[ruleIndex]);
                return true;
            }
            return false;
        }
        
        public bool ApplyRule(IRulable objectToRule, string ruleName)
        {
            foreach (var rule in rules)
            {
                if (rule.RuleName == ruleName)
                {
                    objectToRule.AddRules(rule);
                    return true;
                }
            }

            return false;
        }
        
        public void RemoveRule(IRulable objectToRule, int ruleIndex)
        {
            objectToRule.DeleteRules(rules[ruleIndex]);
        }

        public string ListOfRules()
        {
            string myRules = "### Existing Rules ###\n";
            foreach (var rule in rules)
            {
                myRules += "[" + rules.IndexOf(rule) + "] "+ rule + "\n";
            }

            return myRules;
        }
    }
}
