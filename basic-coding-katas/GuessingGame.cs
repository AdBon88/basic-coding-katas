using System;
namespace basic_coding_katas {
    public class GuessingGame {

        public const int MaxNumber = 10; 
        public static void Start() {

            Random rand = new Random();
            int guessCount = 0;
            int correctNumber = rand.Next(1,MaxNumber);
            int lastGuess = -1;
            int guess;

            Console.WriteLine("Welcome to the Guessing Game!");
            Console.WriteLine($"I'm thinking of a number between 1 and {MaxNumber}...");
            Console.WriteLine("Make a guess:");

            do {
                while ((!Int32.TryParse(Console.ReadLine(), out guess)) || guess < 1 || guess > MaxNumber) {
                    Console.WriteLine($"Invalid guess! Please enter a number between 1 and {MaxNumber}");
                }

                if (guess > correctNumber) {
                    Console.WriteLine("Lower!");
                }
                else if (guess < correctNumber)
                    Console.WriteLine("Higher!");

                if (guess != lastGuess)
                    guessCount++;
                else
                    Console.WriteLine("You just guessed that number, try not counted!");
          
                lastGuess = guess;
            } while (guess != correctNumber!);

            Console.WriteLine("Congratulations! You guessed correctly!");
            Console.WriteLine($"Number of tries: {guessCount}");
        }
    }
}

//ASK WHY I HAD TO ADD THE FILE IN GIT BEFORE EVERY COMMIT
