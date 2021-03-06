using System.Diagnostics;
using System;

namespace WarhammerManager
{

    public static class ArmyFactory
    {
        public static ArmyContainer<T> CreateArmy<T> (string armyName) 
            where T : Army, new()
        {
            T myArmy = new T();
            myArmy.ArmyName= armyName;
            ArmyContainer<T> container = new(myArmy);
            
            Console.WriteLine("New " + myArmy.GetType() + " army created: " + armyName);
            
            return container;
        }

        public static SquadContainer<T1> CreateSquad<T1, T2> (ArmyContainer<T1> myArmy) 
            where T1 : Army 
            where T2 : Squad<T1>, new() 
        {
            T2 mySquad = new T2();
            mySquad.MyArmy = myArmy.MyArmy;
            SquadContainer<T1> container = new(mySquad);

            myArmy.AddSquad(container);
            
            Console.WriteLine("New " + mySquad.GetType() + " created and added to " + myArmy.MyArmy.ArmyName);
            
            return container;
        }

        public static Troop<T1, T2>? CreateTroop<T1, T2, T3>(SquadContainer<T1> mySquad) 
            where T1 : Army 
            where T2 : Squad<T1> 
            where T3 : Troop<T1, T2>, new()
        {
            if(mySquad.MySquad is T2)
            {
                T3 myTroop = new T3();
                myTroop.AddToSquad(mySquad.MySquad);
                mySquad.AddTroop((Troop<T1, Squad<T1>>) myTroop);
                return myTroop;
            }

            return null;
        }
    }
}