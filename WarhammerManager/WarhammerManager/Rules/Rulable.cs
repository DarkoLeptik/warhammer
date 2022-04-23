using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarhammerManager.Rules
{
    public interface IRulable
    {
        public void AddRules(Rule rule);

        public void DeleteRules(Rule rule);

    }
}
