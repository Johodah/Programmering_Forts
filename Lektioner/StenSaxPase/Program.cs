using System;
class Program
{
    static void Main(string[] args)
    {

        bool ContinuePlaying = true;

        while (ContinuePlaying)
        {
            PlayGame();

            Console.WriteLine("Tryck på en knapp för att fortsätta, annars tryck på ESC-knappen för att stänga ner");
            var key = Console.ReadKey(true).Key;
            if (key == ConsoleKey.Escape)
            {
                ContinuePlaying = false;
            }
        }
    }

    static void PlayGame()
    {
        Random random = new Random();
        int PCChoice = random.Next(1, 4);

        Console.WriteLine("Sten, sax påse, välj ditt vapen!");
        Console.WriteLine("1. Sten");
        Console.WriteLine("2. Sax");
        Console.WriteLine("3. Påse");
        Console.WriteLine("4. Hemliga vapnet");
        int PlayerChoice = int.Parse(Console.ReadLine());

        string PCWeapon = GetWeapon(PCChoice);
        string playerWeapon = GetWeapon(PlayerChoice);

        Console.WriteLine($"Datorn valde: {PCWeapon}");
        Console.WriteLine($"Du valde: {playerWeapon}");

        string result = VemVann(PCChoice, PlayerChoice);
        Console.WriteLine(result);
    }


    static string GetWeapon(int choice)
    {
        switch (choice)
        {
            case 1:
                return "Sten";
            case 2:
                return "Sax";
            case 3:
                return "Påse";
            case 4:
                return "Hemliga vapnet";
            default:
                return "ogiltigt val";

        }
    }

    static string VemVann(int PCChoice, int PlayerChoice)
    {
        if (PlayerChoice == PCChoice)
        {
            return "oavgjort, vilken slump!";
        }
        else if ((PlayerChoice == 1 && PCChoice == 2) ||
                (PlayerChoice == 2 && PCChoice == 3) ||
                (PlayerChoice == 3 && PCChoice == 1) ||
                (PlayerChoice == 4))
        {
            return "Du vann, snyggt!";
        }
        else
        {
            return "Ajajajajajajajajaj, du förlorade, synd.";
        }


    }
}