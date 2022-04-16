using System.Diagnostics;
using System;

namespace WarhammerManager
{

    public static class ArmyFactory
    {
        public static ArmyContainer<T> CreateArmy<T> (string armyName) where T : Army, new()
        {
            Console.WriteLine("You want to create an army ? Please wait it's not possible yet, but it soon will be ");

            T myArmy = new T();
            myArmy.armyName= armyName;
            ArmyContainer<T> container = new(myArmy);
            return container;
        }

        public static SquadContainer<T1> CreateSquad<T1, T2> (T1 myArmy) where T1 : Army where T2 : Squad<T1>, new() 
        {
            T2 mySquad = new T2();
            mySquad.MyArmy = myArmy;
            SquadContainer<T1> container = new(mySquad);
            return container;
                

        }

    }
}