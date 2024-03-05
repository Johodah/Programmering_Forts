namespace Lektion6
{
    public class Monster
    {
        private int hitpoints;
        private string name;

        public Monster(int hitpoints, string name)
        {
            this.hitpoints = hitpoints;
            this.name = name;
        }

        public string MakeSound()
        {
            Console.Beep();
        }

        public int GetHitpoints()
        {
            return hitpoints;
        }

        public void SetHitpoints(int newHitpoints)
        {
            hitpoints = newHitpoints;
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string newName)
        {
            name = newName;
        }
    }
}