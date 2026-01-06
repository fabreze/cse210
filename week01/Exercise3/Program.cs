using System;

class Program
{
    static void Main(string[] args)
    {
        bool playAgain = true;
        Random rand = new Random();

        while (playAgain)
        {
            bool isCorrect = false;
            int guessCount = 0;
            int magicNumber = rand.Next(1, 101);

            do
            {
                Console.WriteLine("What is your guess?");
                int userGuess = int.Parse(Console.ReadLine());

                if (userGuess < magicNumber)
                {
                    Console.WriteLine("Higher");
                    guessCount++;
                }
                else if (userGuess > magicNumber)
                {
                    Console.WriteLine("Lower");
                    guessCount++;
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    isCorrect = true;
                }
            } while (!isCorrect);

            Console.WriteLine($"You took {guessCount} guesses to find the number {magicNumber}.");
            Console.WriteLine("Do you want to play again? (y/n)");
            string response = Console.ReadLine().ToLower();

            if (response == "n")
            {
                playAgain = false;
            }
        }
    }
}