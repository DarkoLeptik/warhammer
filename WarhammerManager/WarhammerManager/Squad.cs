using System;
using WarhammerManager.Equipments;

namespace WarhammerManager 
{

    public abstract class Squad<T> where T : Army
    {
        private T? _myArmy;
        public AuthorizedEquipments MyAuthorizedEquipments = new AuthorizedEquipments();
        
        public T? MyArmy
        {
            get
            {
                return _myArmy;
            }
            internal set
            {
                _myArmy = value;
            }
        }

        protected Squad(T associatedArmy)
        {
            _myArmy = associatedArmy;

        }

        protected Squad()
        {

        }

        internal bool IsEquipmentAuthorized(string name)
        {
            if (MyAuthorizedEquipments.FindEquipment(name))
                return true;

            return _myArmy != null && _myArmy.MyAuthorizedEquipments.FindEquipment(name);
        }
    }
}