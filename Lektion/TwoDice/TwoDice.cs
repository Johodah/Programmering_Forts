namespace Lektion1
{
    internal class TwoDice
    {
        public static void Main(string[] args)
        {
            Random random = new Random();
            
            int FirstDie = random.Next(1, 6);
            int SecondDie = random.Next(1, 6);

            Console.WriteLine($" You rolled " + FirstDie + " And " + SecondDie + " ");

            if (FirstDie == SecondDie) 
            { Console.WriteLine("Du fick två " +)
            }
            
        }
    }
}