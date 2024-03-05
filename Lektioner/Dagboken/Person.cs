
//class Program
//{
//    public static void Main(string[] args)
//    {
//        Console.WriteLine("Hej, vad vill du vända på? ");
//        string input = Console.ReadLine();


//        var NewString = ReverseString(input);  
//        Console.WriteLine(NewString);

//        Console.Write("Dags att kalkylera. Ge mig två tal att plussa, ett i taget: ");
//        int n1 = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("and another one");
//        int n2 = Convert.ToInt32(Console.ReadLine());
//        int total = CalculateProduct(n1, n2);
//        Console.WriteLine("Summan av siffrorna blir: " + total);

//        Console.WriteLine("Nu ska vi räkna kvadratrot, ge mig ett nummer att finurla på: ");
//        double R1 = Convert.ToDouble(Console.ReadLine());
//        double R2 = CalculateRoot(R1);
//        Console.WriteLine("Kvadratroten av: " + R1 + " blir " + R2);


//    }

//    public static string ReverseString(string StringToReverse)
//    {
//        var charArray = StringToReverse.ToCharArray();
//        Array.Reverse(charArray);

//        return new string(charArray);
//    }
//    public static int CalculateProduct(int n1, int n2)
//    {
//        int total;
//        total = n1 + n2;
//        return total;
//    }

//    public static double CalculateRoot(double R1)
//    {
//        double R2 = Math.Sqrt(R1);
//        return R2;
//    }
//}


using System.ComponentModel.DataAnnotations;
using System.Net.Cache;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

public class Person
{
    private string _firstName;
    private string _lastName;
    private int _age;
    private string _email;
    private string _password;

    public Person(string firstname, string lastname, int age, string email, string password)
    {
        _firstName = firstname;
        _lastName = lastname;
        _age = age;
        _email = email;
        _password = password;

    }

    public string FirstName
    {
        get { return _firstName; }
        set { _firstName = value; }
    }

    public string LastName
    {
        get { return _lastName; }
        set { _lastName = value; }
    }

    public int Age
    {
        get { return _age; }
        set { _age = value; }
    }

    public string Email
    {
        get { return _email; }
        set { _email = value; }
    }

    public string Password
    {
        get { return _password; }
        set { _password = value; }
    }
}
