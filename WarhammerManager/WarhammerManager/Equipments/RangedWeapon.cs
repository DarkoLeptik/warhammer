namespace WarhammerManager.Equipments;

public class RangedWeapon : Weapon
{
    public int Range { get; internal set; } 
    
    public RangedWeapon(string weaponName, int attack, int range) : base(weaponName, attack)
    {
        Range = range;
    }
}