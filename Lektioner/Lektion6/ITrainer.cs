
using Lektion6;

public interface ITrainer
{
    const int maxTeamSize = 6;
    void CatchPokemon(Pokemon pokemon);
    void Fight(ITrainer foe);
    string Shittalk();
}
