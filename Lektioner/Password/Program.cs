using System.ComponentModel.Design;
using System.Text.RegularExpressions;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hej, dags att skriva in lösenordet! ");
        string password = Console.ReadLine();

        if (IsValidPassword(password)) 
        {
            Console.WriteLine("Giltigt, snyggt jag sparar den");    
        }

        else
        {
            Console.WriteLine("Tyvärr, du har skrivit fel");
        }

        static bool IsValidPassword(string password)
        {
            if (password.Length < 8)
                return false;


            if (!Regex.IsMatch(password, @"^(?=.*[a-z].*[a-z])(?=.*[A-Z].*[A-Z])(?=.*[^a-zA-Z0-9]).{8,}$"))
                return false;

            if (!Regex.IsMatch(password, @"hej|lösen|hopp", RegexOptions.IgnoreCase))
                return false;

            return true;
        }

 
        
    }
    
    
}