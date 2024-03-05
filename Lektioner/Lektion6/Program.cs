namespace Lektion6
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Pokemon pikachu = new(56, "Pikachu", "Electric", 20);
            AshKetchum ash = new(pikachu);
            ash.PresentTeam();

            Console.WriteLine("=============================");

            Pokemon squirtle = new(87, "Squirtle", "Water", 12);

            Console.WriteLine("=============================");

            Mewtwo mewtwo = new(102, "Mewtwo", "Psychic", 100);
            mewtwo.fight(ash);
            mewtwo.CatchPokemon(pikachu);


            Console.WriteLine("=============================");

            pikachu.attack(mewtwo);
        }
    }
}