namespace WarhammerManager
{

    public abstract class Army
    {
        internal string armyName;

        public Army(string _armyName)
        {
            armyName = _armyName;
        }
        public Army()
        {
            armyName = "NoName";
        }


    }
}