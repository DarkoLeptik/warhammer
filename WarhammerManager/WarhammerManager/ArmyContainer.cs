namespace WarhammerManager;

public class ArmyContainer{
    private Army myArmy;
    private SquadContainer [] listOfSquad;
    public ArmyContainer(Army army){
        myArmy = army;

    } 
    public AddSquad(SquadContainer squad){
        listOfSquad.Add(squad);
    }
}