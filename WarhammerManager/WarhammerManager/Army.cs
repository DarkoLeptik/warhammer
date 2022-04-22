using WarhammerManager.Equipments;

namespace WarhammerManager
{

    public abstract class Army
    {
        internal string ArmyName;
        public AuthorizedEquipments MyAuthorizedEquipments = new AuthorizedEquipments();

        protected Army(string armyName)
        {
            ArmyName = armyName;
        }
        protected Army()
        {
            ArmyName = "NoName";
        }
    }
}