namespace Lektion6
{
    public class Mewtwo : Pokemon, ITrainer
    {
        public Mewtwo(int hitpoints, string name, string type, int evolutions) : base(hitpoints, name, type, evolutions)
        {
        }

        public void CatchPokemon(Pokemon pokemon)
        {
            throw new NotImplementedException();
        }

        public void Fight(ITrainer foe)
        {
            throw new NotImplementedException();
        }

        public string Shittalk()
        {
            return ("I see now how the circumstances of one's birth are irrelevant. It is what you do with the gift of life that determines who you are");
        }
    }
}