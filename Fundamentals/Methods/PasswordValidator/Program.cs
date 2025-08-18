using System;
using System.Linq;

namespace Fundamentals
{

    class Program
    {

        static void Main(string[] args)
        {

            string password = Console.ReadLine();
            CharactersLenght(password);
            LettersAndDigits(password);
            Digits(password);
            if (CountChecker == 3)
            {
                Console.WriteLine("Password is valid");
            }

        }
        static int CountChecker = 0;
        static void CharactersLenght(string password)
        {
            if (password.Length >= 6 && password.Length <= 10)
            {
                CountChecker++;
            }
            else
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
        }
        static void Digits(string password)
        {
            int counter = 0;
            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsDigit(password[i]))
                {
                    counter++;
                }
            }
            if (counter >= 2)
            {
                CountChecker++;
            }
            else
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
        }
        static void LettersAndDigits(string password)
        {
            bool checker = false;
            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsLetterOrDigit(password[i]))
                {

                }
                else
                {
                    checker = true;
                    break;
                }
            }
            if (checker)
            {

                Console.WriteLine("Password must consist only of letters and digits");
            }
            else
            {
                CountChecker++;
            }
        }
    }
}