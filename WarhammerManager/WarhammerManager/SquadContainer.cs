using System;

namespace WarhammerManager
{

    public class SquadContainer<T1, T2> 
        where T1 : Army
        where T2 : Squad<T1>
    {
        private T2 _mySquad;
        private List<Troop<T1, T2>> _myTroops;

        public T2 MySquad
        {
            get
            {
                return _mySquad;
            }
            internal set
            {
                _mySquad = value;
            }
        }

        public SquadContainer(T2 mySquad)
        {
            _mySquad = mySquad;
            _myTroops = new List<Troop<T1,T2>>();
        }

        public override string ToString()
        {
            string listOfTroops = "<<-- " + _mySquad.GetType() + " -->>\n";

            foreach (var troop in _myTroops)
            {
                listOfTroops += troop.ToString();
            }
            return listOfTroops;
        }

        public void AddTroop(Troop<T1, T2> newRecruit)
        {
            if (_myTroops.Contains(newRecruit))
            {
                return;
            }
            _myTroops.Add(newRecruit);
        }
    }
}