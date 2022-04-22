using System;
using System.Collections.Generic;

namespace WarhammerManager
{

    public class ArmyContainer<T> where T : Army
    {
        private T _myArmy;


        public T MyArmy
        {
            get
            {
                return _myArmy;
            }
            internal set
            {
                _myArmy = value;

            }
        }

        private ListOfSquad<T> listOfSquad;
        public ArmyContainer(T army)
        {
            _myArmy = army;
            listOfSquad = new ListOfSquad<T>();
        }


        public void AddSquad(SquadContainer<T, Squad<T>> squad)
        {
            listOfSquad.Add(squad);
        }
    }
}