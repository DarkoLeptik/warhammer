using System.Diagnostics;
using System;

namespace WarhammerManager
{

    public static class ArmyFactory
    {
        static ArmyContainer<T> CreateArmy<T> (string armyName) where T : Army, new()
        {
            Console.WriteLine("You want to create an army ? Please wait it's not possible yet, but it soon will be ");

            T myArmy = new T();
            myArmy.armyName= armyName;
            ArmyContainer<T> container = new(myArmy);
            return container;
        }

    }
}