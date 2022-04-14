using WarhammerManager.Rules;

namespace WarhammerManager;

public abstract class Troop<T1,T2> : Rulable
    where T1 : Squad<T2> 
    where T2 : Army
{
    private T1 _mySquad;

    protected Troop(T1 newSquad)
    {
        _mySquad = newSquad;
    }
}