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
        public int Attack
        {
            get { return _atk; }
            set { _atk = value; }
        }
        private int _armor;
        public int Armor
        {
            get { return _armor; }
            set { _armor = value; }
        }
        private List<Rule> _rulesApplied;
        public List<Rule> RulesApplied
        {
            get { return _rulesApplied; }
            set { _rulesApplied = value; }
        }
        protected Troop(T1 newSquad)
        {
            _rulesApplied = new List<Rule>();
            _mySquad = newSquad;
        }

        public void AddRules(Rule rule)
        {
            if (_rulesApplied.Contains(rule))
            {
                Console.WriteLine("Cette règle est déjà appliquée à cette arme");
            }
            else
            {
                rule.ApplyRuleToTroop<T1, T2>(this);
            }
        }

        public void DeleteRules(Rule rule)
        {
            if (_rulesApplied.Contains(rule))
            {
                rule.RemoveRuleToTroop<T1, T2>(this);
            }
            else
            {
                Console.WriteLine("Cette règle n'est pas appliquée à cette arme");
            }
        }
    }
}