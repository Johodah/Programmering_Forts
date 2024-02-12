using DiaryEntry;

class Program
{
    // Implementera metoderna som beskrivs ovan
    // ...

    static void Main(string[] args)
    {
        List<DiaryEntry> diaryEntries = new List<DiaryEntry>();

        // Huvudmenyloop
        while (true)
        {
            Console.WriteLine("1. Läs dagboksinlägg");
            Console.WriteLine("2. Skapa nytt dagboksinlägg");
            Console.WriteLine("3. Avsluta");

            Console.Write("Välj ett alternativ: ");
            int val = Convert.ToInt32(Console.ReadLine());

            switch (val)
            {
                case 1:
                    ReadEntry(diaryEntry);
                    break;
                case 2:
                    CreateEntry(diaryEntry);

                    break;
                case 3:
                    Console.WriteLine("Avslutar programmet...");
                    return;
                default:
                    Console.WriteLine("Ogiltigt val. Försök igen.");
                    break;
            }
        }
    }

    ReadEntry();

    CreateEntry(DateTime datum, string rubrik, string innehåll)
    {
        Console.WriteLine("Skriv in datum: ");
        datum = DateTime.Parse(Console.ReadLine());

        Console.WriteLine("Skriv in en rubrik: ");
        rubrik = Console.ReadLine();

        Console.WriteLine("Skriv vad du vill lägga in i dagboken: ");
        innehåll = Console.ReadLine();
    }
        }

