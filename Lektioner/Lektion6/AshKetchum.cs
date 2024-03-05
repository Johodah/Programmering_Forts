using Lektion6;

public class AshKetchum : ITrainer
{
    private Pokemon mainPokemon;
    private List<Pokemon> team = new List<Pokemon>(6);

    public AshKetchum(Pokemon mainPokemon)
    {
        this.mainPokemon = mainPokemon;
    }

    public void PresentTeam()
    {
        for (int i = 0; i < team.Count; i++)
        {
            Console.WriteLine("Look at my super cool pokemon! I've got: ");
            Console.WriteLine($"A {team[i].GetName()} ");
            Console.WriteLine("See how cool they are!?!?!?");
        }
    }

    public void CatchPokemon(Pokemon pokemon)
    {

    }

    public void Fight(ITrainer trainer)
    {

    }

    public string Shittalk()
    {
        return "I have no pockets! So where do I put my pokeballs you ask? Trainers secret ;)";
    }
}