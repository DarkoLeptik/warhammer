namespace WarhammerManager;

public class SquadContainer<T> where T : Army
{
    private Squad<T> _mySquad;

    public SquadContainer(Squad<T> mySquad)
    {
        _mySquad = mySquad;
    }
}