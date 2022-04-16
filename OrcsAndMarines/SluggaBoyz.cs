namespace OrcsAndMarines
{

    public class SluggaBoyz : WarhammerManager.Squad<Ork>
    {
        public SluggaBoyz(Ork associatedArmy) : base(associatedArmy)
        {
            Console.WriteLine("We are the SluggaBoyzzz !!!");
        }

        public SluggaBoyz()
        {
            Console.WriteLine("We are the SluggaBoyzzz !!!");
        }
    }
}