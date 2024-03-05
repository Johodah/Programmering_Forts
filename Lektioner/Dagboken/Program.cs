using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetoderGrund
{
   internal class Program 
    {
        public static void Main(string[] args)
        {
            Person person = new("Johnny", "Dahle", 29, "johnny.dahlwe", "Password");
            Console.WriteLine($"{person.FirstName} {person.LastName} {person.Age} {person.Email} {person.Password}");
        
        }

    }
}
