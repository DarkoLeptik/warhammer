namespace WarhammerManager.Equipments;

public sealed class AuthorizedEquipments
{
    private List<string> _authorizedEquipments;

    internal AuthorizedEquipments()
    {
        _authorizedEquipments = new List<string>();
    }
    
    public bool AddAuthorizedEquipment(string name)
    {
        if (_authorizedEquipments.Contains(name))
        {
            return false;
        }
        Console.WriteLine(name + " can now be equipped.");
        _authorizedEquipments.Add(name);
        return true;
    }
        
    public bool RemoveAuthorizedEquipment(string name)
    {
        return _authorizedEquipments.Remove(name);
    }

    internal bool FindEquipment(string name)
    {
        return _authorizedEquipments.Contains(name);
    }
}