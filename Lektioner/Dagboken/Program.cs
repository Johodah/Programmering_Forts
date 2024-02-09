
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hej, vad vill du vända på? ");
        string input = Console.ReadLine();

       
        var NewString = ReverseString(input);  
        Console.WriteLine(NewString);

        Console.Write("Dags att kalkylera. Ge mig två tal att plussa, ett i taget: ");
        int n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("and another one");
        int n2 = Convert.ToInt32(Console.ReadLine());
        int total = CalculateProduct(n1, n2);
        Console.WriteLine("Summan av siffrorna blir: " + total);

        Console.WriteLine("Nu ska vi räkna kvadratrot, ge mig ett nummer att finurla på: ");
        double R1 = Convert.ToDouble(Console.ReadLine());
        double R2 = CalculateRoot(R1);
        Console.WriteLine("Kvadratroten av: " + R1 + " blir " + R2);
        
        
    }

    public static string ReverseString(string StringToReverse)
    {
        var charArray = StringToReverse.ToCharArray();
        Array.Reverse(charArray);

        return new string(charArray);
    }
    public static int CalculateProduct(int n1, int n2)
    {
        int total;
        total = n1 + n2;
        return total;
    }

    public static double CalculateRoot(double R1)
    {
        double R2 = Math.Sqrt(R1);
        return R2;
    }
}

