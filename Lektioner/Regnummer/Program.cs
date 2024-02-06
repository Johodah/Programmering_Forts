using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

class Program
{
    public static int Main()
    {
        Console.WriteLine("Ge mig ett giltigt regnr: ");
        string Regnr = Console.ReadLine();

        if (IsRegnrValid(Regnr))
        {
            Console.WriteLine("Jajamänsan!");
        }
        else
        {
            Console.WriteLine("Nej, du skrev fel walla");
        }
        bool IsRegnrValid(string Regnr)
        {
            Regex pattern = new Regex(@"^[A-Za-z]{3}\d{3}$|^[A-Za-z]{3}\d{2}[A-Za-z]{1}$");
            return pattern.IsMatch(Regnr);
        }

        return 0;
    }
}

