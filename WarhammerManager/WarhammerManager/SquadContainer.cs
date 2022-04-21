using System;

namespace WarhammerManager
{

    public class SquadContainer<T> where T : Army
    {
        private Squad<T> _mySquad;

        public Squad<T> MySquad
        {
            get
            {
                return _mySquad;
            }
            internal set
            {
                _mySquad = value;
            }
        }

        public SquadContainer(Squad<T> mySquad)
        {
            _mySquad = mySquad;
        }
    }
}