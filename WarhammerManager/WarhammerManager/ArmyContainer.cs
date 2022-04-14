using System;

namespace WarhammerManager
{

    public class ArmyContainer<T> where T : Army
    {
        private Army myArmy;
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