using System;

namespace _04.PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string passWord = Console.ReadLine();
            if (PasswordBetweenSixAndTenChar(passWord) && PasswordLetterAndDegits(passWord) && PasswordMustHaveTwoDigits(passWord))
            {
                Console.WriteLine("Password is valid");
            }
            if (!PasswordBetweenSixAndTenChar(passWord))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!PasswordLetterAndDegits(passWord))
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!PasswordMustHaveTwoDigits(passWord))
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
        }

        static bool PasswordBetweenSixAndTenChar(string password)
        {
            bool validPassword = false;

            if (password.Length >= 6 && password.Length <= 10)
            {
                validPassword = true;
            }

            return validPassword;
        }

        static bool PasswordLetterAndDegits(string password)
        {
            foreach (char ch in password)
            {
                if (!char.IsLetterOrDigit(ch))
                {
                    return false;
                }

            }
            return true;
        }

        static bool PasswordMustHaveTwoDigits(string password)
        {

            int digitCount = 0;

            foreach (char item in password)
            {
                if (char.IsDigit(item))
                {
                    digitCount++;
                }
            }


            if (digitCount >= 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
