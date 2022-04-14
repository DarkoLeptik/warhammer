using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarhammerManager.Rules
{
    interface Rulable
    {
        public void AddRules(Rule rule);

        public void DeleteRules(Rule rule);

        public List<Rule> getRulesApplied();

    }
}
