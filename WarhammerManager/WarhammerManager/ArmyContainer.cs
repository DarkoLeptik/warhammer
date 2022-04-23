namespace WarhammerManager
{

    public class ArmyContainer<T> where T : Army
    {
        private readonly T _myArmy;


        public T MyArmy => _myArmy;

        private readonly ListOfSquad<T> _listOfSquad;
        internal ArmyContainer(T army)
        {
            _myArmy = army;
            _listOfSquad = new ListOfSquad<T>();
        }


        internal void AddSquad(SquadContainer<T> squad)
        {
            _listOfSquad.Add(squad);
        }
        
        public bool RemoveSquad(SquadContainer<T> squad)
        {
            return _listOfSquad.Remove(squad);
        }
        
        public override string ToString()
        {
            string description = "<<<--- " + _myArmy.ArmyName + " --->>>\n";
            foreach (var squadContainer in _listOfSquad)
            {
                description += squadContainer + "\n";
            }
            return description;
        }
    }
}