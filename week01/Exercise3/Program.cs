using System;

class Program
{
    static void Main(string[] args)
    {
        string response = "";
        Console.Write("Do you want to play a game? (Yes/No): ");
        response = Console.ReadLine();
        do
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);
            int userGuess = 0;
            int numberOfGuesses = 0;
            do{
                Console.Write("Enter your guess: ");
                userGuess = int.Parse(Console.ReadLine());
                numberOfGuesses++;
                if(userGuess < magicNumber){
                    Console.WriteLine("Too low!");
                }else if(userGuess > magicNumber){
                    Console.WriteLine("Too high!");
                }
                if(userGuess == magicNumber){
                    Console.WriteLine("Congratulations! You guessed the magic number in " + numberOfGuesses + " guesses!");
                }
            }while(userGuess != magicNumber);
        Console.Write("Do you want to play a game? (Yes/No): ");
            response = Console.ReadLine();

        }
        while(response == "Yes");
        
    }
}