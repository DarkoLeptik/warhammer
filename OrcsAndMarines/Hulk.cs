using WarhammerManager;
using WarhammerManager.Rules;

namespace OrcsAndMarines;

public class Hulk : Troop<Ork, SluggaBoyz>
{
    public Hulk() 
    {
        if (!RulesFactory.Instance.ApplyRule(this, "Hulk strength"))
        {
            int ruleIndex = RulesFactory.Instance.CreateRule(2, 0, "Hulk strength");
            RulesFactory.Instance.ApplyRule(this, ruleIndex);
        }
        Console.WriteLine("I am Huulk !");
    }
}