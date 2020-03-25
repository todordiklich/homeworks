using System;

namespace _04._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            PasswordValidator(password);
        }
        static void PasswordValidator(string pass)
        {
            if (LengthValidator(pass))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (DigitLettersValidator(pass))
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (TwoDigitValidator(pass))
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if (LengthValidator(pass) == false && DigitLettersValidator(pass) == false && TwoDigitValidator(pass) == false)
            {
                Console.WriteLine("Password is valid");
            }

        }
        static bool LengthValidator(string pass)
        {
            bool lengthValid = false;
            if (pass.Length < 6 || pass.Length > 10)
            {
                lengthValid = true;
            }
            return lengthValid;
        }
        static bool DigitLettersValidator(string pass)
        {
            bool digitLetters = false;
            for (int i = 0; i < pass.Length; i++)
            {
                if (!char.IsDigit(pass[i]) && !char.IsLetter(pass[i]))
                {
                    digitLetters = true;
                    break;
                }
            }
            return digitLetters;
        }
        static bool TwoDigitValidator(string pass)
        {
            bool twoDigits = false;
            int count = 0;
            for (int i = 0; i < pass.Length; i++)
            {
                if (char.IsDigit(pass[i]))
                {
                    count++;
                }
            }
            if (count < 2)
            {
                twoDigits = true;
            }
            return twoDigits;
        }
    }
}
