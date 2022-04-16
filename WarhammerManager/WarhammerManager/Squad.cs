using System;

namespace WarhammerManager 
{

    public abstract class Squad<T> where T : Army
    {
        private T? _myArmy;
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
        
    }
}