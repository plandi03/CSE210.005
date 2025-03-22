using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Scripture Memorizer!");

        // create a reference and scripture you can change the scripture and reference
        Reference reference = new Reference("1 Nephi", 2, 15);
        string text = "And my father dwelt in a tent.";
        Scripture scripture = new Scripture(reference, text);

        // Display the scripture and hide words iteratively
        while (true)
        {
            Console.Clear();   // clear the console
            Console.WriteLine(scripture.GetDisplayText()); // this will display the scripture

            // thii will check if all words are hidden
            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("\nGood job! You have memorized the scripture.");
                break;
            }

            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");
            string input = Console.ReadLine(); // this will take the input from the user and check if the user wants to quit or not, the blank input will hide more words
            if (input.ToLower() == "quit") // this will check if the user wants to quit
            {
                break;
            }

            scripture.HideRandomWords(2); // this is for hide 2 random words each time
        }

        Console.WriteLine("\nGoodbye!");
    }
}