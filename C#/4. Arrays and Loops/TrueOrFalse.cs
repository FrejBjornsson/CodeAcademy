using System;

namespace TrueOrFalse
{
    class Program
    {
        static void Main(string[] args)
        {
            // Do not edit these lines
            Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
            string entry = Console.ReadLine();
            Tools.SetUpInputStream(entry);

            // Type your code below

            string[] questions = new string[]
            {
        "An eggplant is also known as an aubergine.",
        "Eggplants are a species in the nightshade family.",
        "According to botanical definition, eggplant is a vegetable.",
        "When cut open, eggplants do not brown (oxidation)",
        "Eggplants were originally domesticated from the wild species bitter apple, or S. inconum."};
            // The correct answers
            bool[] answers = new bool[] { true, true, false, false, true };

            RunQuiz(questions, answers);

        }

        static void RunQuiz(string[] questions, bool[] answers)
        {

            // The user replies
            bool[] responses = new bool[questions.Length];

            // Checking if we have as many answers as questions
            if (questions.Length != answers.Length)
            {
                Console.WriteLine("You need as many answers as questions!");
            }

            // Ask the questions and store the user replies
            int askingIndex = 0;
            foreach (string i in questions)
            {
                string input;
                bool isBool;
                bool inputBool;

                Console.WriteLine(questions[askingIndex]);
                Console.WriteLine("True or false?");
                input = Console.ReadLine();
                isBool = Boolean.TryParse(input, out inputBool);

                while (!isBool)
                {
                    Console.WriteLine("Please respond with 'true' or 'false'.");
                    input = Console.ReadLine();
                    isBool = Boolean.TryParse(input, out inputBool);

                }

                responses[askingIndex] = Convert.ToBoolean(input);
                askingIndex++;

            }

            //Calculate score
            int scoringIndex = 0;
            int score = 0;

            foreach (bool answer in answers)
            {
                bool response = responses[scoringIndex];
                Console.WriteLine($"{scoringIndex + 1}. Input: {response} | Answer: {answer}");

                if (response == answer)
                {
                    score++;
                }

                scoringIndex++;
            }

            Console.WriteLine($"You got {score} ot of {answers.Length} correct!");

        }
    }
}