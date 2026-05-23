using System;

// Creativity explanation:
// 1) Added an interactive "hint" system: if the user types 'hint' in the console, 
// the program detects words that are currently hidden and reveals one of them at random.
// 2) Enhanced the random hiding logic to ensure it only selects from words that 
// are not already hidden, preventing wasted attempts on blank spaces.

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string text = "Trust in the Lord with all thine heart and lean not unto thine own understanding.";
        Scripture scripture = new Scripture(reference, text);

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press ENTER to hide words, type 'hint' for help, or type 'quit' to exit.");

            string input = Console.ReadLine().Trim().ToLower();

            if (input == "quit")
            {
                break;
            }
            // 1) Interactive 'hint' command system to trigger word revelation
            else if (input == "hint")
            {
                scripture.RevealRandomWord();
                continue; 
            }

            scripture.HideRandomWords(3);

            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine();
                Console.WriteLine("Excellent work! You have successfully memorized the scripture.");
                break;
            }
        }
    }
}