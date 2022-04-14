using WarhammerManager;
using System;

namespace OrcsAndMarines
{

    public class Nob : Troop<SluggaBoyz, Ork>
    {
        public Nob(SluggaBoyz newSquad) : base(newSquad)
        {
            Console.WriteLine("I am Nob.");
        }
    }
}