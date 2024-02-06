internal class Program
{
    private static void Main(string[] args)
    {
        Random random = new Random();

        int FirstDice = random.Next(1, 6);
        int SecondDice = random.Next(1, 6);
        int ThirdDice = random.Next(1, 6);

        if (FirstDice == SecondDice || FirstDice == ThirdDice)
        {
            Console.WriteLine("Du fick tre " + FirstDice + ":or");
        }
        else
        {
            Console.WriteLine($"Du fick: " + FirstDice + ", " + SecondDice + " och " + ThirdDice);
        }

    }
}