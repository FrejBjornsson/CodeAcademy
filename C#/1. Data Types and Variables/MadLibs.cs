using System;

namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            This program: A short story with blank spaces (asking for different types of words). Words from the player to fill in those blanks.
            Author: Frej Björnsson
            */


            // Let the user know that the program is starting:
            Console.WriteLine($"Welcome to This Morning!");


            // Define user input and variables:
            Console.Write("Enter a name: ");
            string name = Console.ReadLine();

            Console.WriteLine("You will now enter three adjectives. \nAn adjective is a word that describes a noun, like a color (‘blue’), or feeling (‘silly’), texture (‘soft’)");

            Console.Write("Enter adjective one: ");
            string adj1 = Console.ReadLine();

            Console.Write("Enter adjective two: ");
            string adj2 = Console.ReadLine();

            Console.Write("Enter adjective three: ");
            string adj3 = Console.ReadLine();

            Console.WriteLine("You will now enter a verb. \nA verb is a word that represents an action, like ‘sit’, ‘eat’, ‘sleep’.");
            Console.Write("Enter a verb: ");
            string verb = Console.ReadLine();

            Console.WriteLine("You will now enter two nouns. \nA noun is a person (‘girl’), place (‘cabin’), or thing (‘toaster’).");
            Console.Write("Enter noun one: ");
            string noun1 = Console.ReadLine();
            Console.Write("Enter noun two: ");
            string noun2 = Console.ReadLine();

            Console.WriteLine("You will now get a series of questions to answer.");

            Console.Write("What's your favorite animal? ");
            string animal = Console.ReadLine();

            Console.Write("What's your least favorite food? ");
            string food = Console.ReadLine();

            Console.Write("What's your favorite fruit? ");
            string fruit = Console.ReadLine();

            Console.Write("What superhero is the lamest? ");
            string superhero = Console.ReadLine();

            Console.Write("What country do you live in? ");
            string country = Console.ReadLine();

            Console.Write("What's your favorite dessert? ");
            string dessert = Console.ReadLine();

            Console.Write("Add a zero after your birth year, what number do you get? ");
            int year = Int32.Parse(Console.ReadLine());




            // The template for the story:

            string story = $"This morning {name} woke up feeling {adj1}. \n'It is going to be a {adj2} day!' \nOutside, a bunch of {animal}s were protesting to keep {food} in stores. \nThey began to {verb} to the rhythm of the {noun1}, which made all the {fruit}s very {adj3}. \nConcerned, {name} texted {superhero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. \n{name} woke up in the year {year}, in a world where {noun2}s ruled the world.\n";


            // Print the story:
            Console.Write(story);

        }
    }
}
