using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class Program
    {
        static void Main(string[] args)
        {
            RegexValidation regexValidation = new RegexValidation();//Create object
            Console.WriteLine("Enter Your First Name::-");//take input from the user
            string FirstName = Console.ReadLine();//Store the input for firstname
            Console.WriteLine(regexValidation.ValidateFirstName(FirstName));
        }
    }
}
