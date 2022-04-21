using WarhammerManager.Equipments;

namespace WarhammerManager
{

    public abstract class Army
    {
        internal string armyName;
        public AuthorizedEquipments myConstraints = new AuthorizedEquipments();

        protected Army(string _armyName)
        {
            armyName = _armyName;
        }
        protected Army()
        {
            armyName = "NoName";
        }
    }
}