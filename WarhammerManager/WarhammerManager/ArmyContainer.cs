using System;
using System.Collections.Generic;

namespace WarhammerManager
{

    public class ArmyContainer<T> where T : Army
    {
        private T myArmy;


        public T MyArmy
        {
            get
            {
                return myArmy;
            }
            internal set
            {
                myArmy = value;

            }
        }

        private List<SquadContainer<T>> listOfSquad;
        public ArmyContainer(T army)
        {
            myArmy = army;
            listOfSquad = new List<SquadContainer<T>>();
        }


        public void AddSquad(SquadContainer<T> squad)
        {
            listOfSquad.Add(squad);
        }
    }
}