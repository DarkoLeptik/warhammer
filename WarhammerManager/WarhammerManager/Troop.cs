using System;
using WarhammerManager.Rules;

namespace WarhammerManager
{

    public abstract class Troop<T1, T2> : Rulable
        where T1 : Squad<T2>
        where T2 : Army
    {
        private T1 _mySquad;
        private int _atk;
        private int _armor;
        private List<Rule> _rulesApplied;
        protected Troop(T1 newSquad)
        {
            _rulesApplied = new List<Rule>();
            _mySquad = newSquad;
        }

        public void AddRules(Rule rule)
        {

        }

        public void DeleteRules(Rule rule)
        {

        }

        public List<Rule> getRulesApplied()
        {
            return _rulesApplied;
        }


    }
}