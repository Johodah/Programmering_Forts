internal class Program
{
    private static void Main(string[] args)
    {
        Random random = new Random();

        int FirstDice = random.Next (1, 6);
        int SecondDice = random.Next(1, 6);
        if ( FirstDice == SecondDice )
        {
            Console.WriteLine("Du fick två stycken " + FirstDice);
        }
        else
        {
            Console.WriteLine($"Du fick: " + FirstDice + " och " + SecondDice);
        }
       
    }
}