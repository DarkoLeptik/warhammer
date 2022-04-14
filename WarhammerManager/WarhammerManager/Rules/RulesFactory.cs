using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarhammerManager.Rules
{
    class RulesFactory
    {
        List<Rules> rules;

        public static RulesFactory instance;

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

        public RulesFactory()
        {
            rules = new List<Rules>();
        }
    }
}
