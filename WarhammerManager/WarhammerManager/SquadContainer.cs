using System;

namespace WarhammerManager
{

    public class SquadContainer<T1> 
        where T1 : Army
        //where T2 : Squad<T1>
    {
        private Squad<T1> _mySquad;
        private List<Troop<T1, Squad<T1>>> _myTroops;

        public Squad<T1> MySquad
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

        public SquadContainer(Squad<T1> mySquad)
        {
            _mySquad = mySquad;
            _myTroops = new List<Troop<T1,Squad<T1>>>();
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

        internal void AddTroop(Troop<T1, Squad<T1>> newRecruit)
        {
            if (_myTroops.Contains(newRecruit))
            {
                return;
            }
            _myTroops.Add(newRecruit);
        }

        public bool RemoveTroop(Troop<T1, Squad<T1>> wrongRecruit)
        {
            return _myTroops.Remove(wrongRecruit);
        }
    }
}