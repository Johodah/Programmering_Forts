namespace Lektion6
{
    public class Pokemon : Monster
    {
        private static int MaxNrAttacks = 4;
        string type;
        int evolutions;
        private List<Attack> AttackMoves;
        
    
    public Pokemon(int hitpoints, string name, string type, int evolutions) : base(hitpoints, name)
        {
            this.type = type;
            this.evolutions = evolutions;
            AttackMoves = [];
        }

        public Pokemon(int hitpoints, string name, string type) : base(hitpoints, name)
        {
            this.type = type;

        }

    }

    public void AttackMoves(Pokemon)
    {

    }
}