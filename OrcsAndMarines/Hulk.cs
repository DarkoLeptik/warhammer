using WarhammerManager;
using WarhammerManager.Rules;

namespace OrcsAndMarines;

public class Hulk : Troop<Ork, SluggaBoyz>
{
    public Hulk() 
    { 
        Console.WriteLine("I am Huulk !");
    }
}