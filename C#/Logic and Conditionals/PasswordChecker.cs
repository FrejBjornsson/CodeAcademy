using System;

namespace PasswordChecker
{
    class Program
    {
        public static void Main(string[] args)
        {
            int minLength = 8;
            string upperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowerCase = "abcdefghijklmnopqrstuvwxyz";
            string digits = "0123456789";
            string specialChars = "!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~";

            Console.WriteLine("Please enter a new strong password of minimum length 8: ");
            string passwordUser = Console.ReadLine();
            int score = 0;
            if ((passwordUser == "password") || (passwordUser == "1234"))
            {
                Console.WriteLine("Your password is too weak, please try again!");
                Console.WriteLine("Please enter a new strong password of minimum length 8: ");
                passwordUser = Console.ReadLine();
            }
            else
            {

                if (passwordUser.Length >= minLength)
                {
                    score++;
                }
                if (Tools.Contains(passwordUser, upperCase))
                {
                    score++;
                }
                if (Tools.Contains(passwordUser, lowerCase))
                {
                    score++;
                }
                if (Tools.Contains(passwordUser, digits))
                {
                    score++;
                }
                if (Tools.Contains(passwordUser, specialChars))
                {
                    score++;
                }

            }
            Console.WriteLine("Your password score is: " + score + " out of 5 and..");

            switch (score)
            {
                case 4:
                case 5:
                    Console.WriteLine("..extremely strong");
                    break;

                case 3:
                    Console.WriteLine("..strong");
                    break;

                case 2:
                    Console.WriteLine("..medium");
                    break;

                case 1:
                    Console.WriteLine("..weak");
                    break;

                default:
                    Console.WriteLine("..worthless");
                    break;
            }
        }
    }
}