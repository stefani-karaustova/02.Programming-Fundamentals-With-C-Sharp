using System;

namespace _04.PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            var password = Console.ReadLine();

            bool isValid = CheckPasswordLength(password) &&
                           CheckLettersAndDigits(password) &&
                           CheckMinimalRequiredDigits(password);

            if (isValid)
            {
                Console.WriteLine("Password is valid");
            }
            else
            {
                if (!CheckPasswordLength(password))
                {
                    Console.WriteLine("Password must be between 6 and 10 characters");
                }

                if (!CheckLettersAndDigits(password))
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                }

                if (!CheckMinimalRequiredDigits(password))
                {
                    Console.WriteLine("Password must have at least 2 digits");
                }
            }
        }

        public static bool CheckPasswordLength(string password)
        {
            if (password.Length >= 6 && password.Length <= 10)
            {
                return true;
            }

            return false;
        }

        public static bool CheckLettersAndDigits(string password)
        {
            foreach (char character in password)
            {
                if (!char.IsLetterOrDigit(character))
                {
                    return false;
                }
            }

            return true;
        }

        public static bool CheckMinimalRequiredDigits(string password)
        {
            var count = 0;

            foreach (char character in password)
            {
                if (char.IsDigit(character))
                {
                    count++;
                }
            }

            if (count >= 2)
            {
                return true;
            }

            return false;
        }
    }
}
