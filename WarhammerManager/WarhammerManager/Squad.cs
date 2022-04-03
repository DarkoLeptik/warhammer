namespace WarhammerManager;

public abstract class Squad<T> where T : Army
{
    private T _myArmy;

    protected Squad(T associatedArmy)
    {
        _myArmy = associatedArmy;
    }
}