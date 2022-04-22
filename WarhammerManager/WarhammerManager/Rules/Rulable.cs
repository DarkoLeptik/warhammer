using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarhammerManager.Rules
{
    public interface Rulable
    {
        internal void AddRules(Rule rule);

        internal void DeleteRules(Rule rule);

    }
}
