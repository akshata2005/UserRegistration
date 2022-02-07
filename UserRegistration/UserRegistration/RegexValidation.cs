using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class RegexValidation
    {
        public static void FirstName()
        {
            string regex = "[A-Z]{1}[a-z]{3,10}$";
            Console.WriteLine("Enter first name");
            string fName = Console.ReadLine();
            Regex rg = new Regex(regex);
            bool result = rg.IsMatch(fName);
            if (result == true)
            {
                Console.WriteLine("valid");
            }
            else
            {
                Console.WriteLine("invalid");
            }
        }
        //method to validate last name
        public static void LastName()
        {
            string regex = "[A-Z]{1}[a-z]{3,10}$";
            Console.WriteLine("Enter Last name");
            string fName = Console.ReadLine();
            Regex rg = new Regex(regex);
            bool result = rg.IsMatch(fName);
            if (result == true)
            {
                Console.WriteLine("valid");
            }
            else
            {
                Console.WriteLine("invalid");
            }
        }
        public static void Email()
        {
            //string regex = "[a-zA-Z0-9_.]+@[a-zA-Z.]+$";
            string regex = "^[a-zA-Z0-9]+([.][a-zA-Z0-9]+)?@[a-zA-Z0-9]+.[a-zA-Z]{2,4}([.][a-zA-Z]{2})?$";
            Console.WriteLine("Enter EmailId");
            string fName = Console.ReadLine();
            Regex rg = new Regex(regex);
            bool result = rg.IsMatch(fName);
            if (result == true)
            {
                Console.WriteLine("valid");
            }
            else
            {
                Console.WriteLine("invalid");
            }
        }
        //method for validateing mobile number
        public static void MobileNumber()
        {
            string regex = "^([0-9]{2}[ ]?)[0-9]{10}$";
            Console.WriteLine("Enter your Mobile Number");
            string mobileNo = Console.ReadLine();
            Regex rg = new Regex(regex);
            bool result = rg.IsMatch(mobileNo);
            if (result == true)
            {
                Console.WriteLine("valid");
            }
            else
            {
                Console.WriteLine("invalid");
            }
        }
        //method for validating password
        public static void Password()
        {
            // string regex = "^[a-zA-Z]{8,}$";
            //string regex = "^[A-Z]{1}[a-z]{8,}$";
            //string regex = "^[A-Z]{1}[a-z0-9]{8,}$";
            string regex = "^[A-Z]{1}[a-z0-9]{8,}[$&+,:;=?@#|'<>.-^*()%!]$";
            Console.WriteLine("Enter your Password :");
            string password = Console.ReadLine();
            Regex rg = new Regex(regex);
            bool result = rg.IsMatch(password);
            if (result == true)
            {
                Console.WriteLine("valid");
            }
            else
            {
                Console.WriteLine("invalid");
            }
        }
    }

}
