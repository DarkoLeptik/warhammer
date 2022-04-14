using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarhammerManager.Rules
{
    public class RulesFactory
    {
        public List<Rules> rules;

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
            rules = new List<Rules>();
            Console.WriteLine("I am an instance of rulefactory !");
        }
    }
}
