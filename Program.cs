using System;
using System.Linq;
using System.Text;

namespace Password_Methods
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please input a password meeting the following conditions:");
            Console.WriteLine("1) The password must be more than 8 characters");
            Console.WriteLine("2) The password must not be null");
            Console.WriteLine("3) The password must have atleast one uppercase letter");
            Console.WriteLine("4) The password must have atleast one lowercase letter");
            Console.WriteLine("5) The password must have atleast one digit");
            string password = Console.ReadLine();

            bool longEnough = IsLongEnough(password);
            Console.WriteLine("Ia the password greater than 8 characters: "+ longEnough);

            bool IsntNull = IsNotNull(password);
            Console.WriteLine("The password is neither null nor empty: " + IsntNull);

            bool oneUpper = HasOneUpper(password);
            Console.WriteLine("The password has one uppercase letter: "+ oneUpper);

            bool oneLower = HasOneLower(password);
            Console.WriteLine("The password has one lowercase letter: " + oneLower);

            bool oneDigit = HasOneDigit(password);
            Console.WriteLine("The password has one lowercase letter: " + oneDigit);
        }

        public static bool IsLongEnough(string input)
        {
            int len = input.Length;
            if(len > 8)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsNotNull(string input)
        {
            if (input != "" && input != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool HasOneUpper(string input)
        {
            if (input.Any(char.IsUpper))
            {
                return true;
            }
            return false;
        }

        public static bool HasOneLower(string input)
        {
            if (input.Any(char.IsLower))
            {
                return true;
            }
            return false;
        }

        public static bool HasOneDigit(string input)
        {
            if (input.Any(char.IsDigit))
            {
                return true;
            }
            return false;
        }
    }
}

