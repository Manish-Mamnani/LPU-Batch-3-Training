using System;

namespace LoopStatements;

public class GuessingGame
{
    public void GuessingGameMain()
    {
        Random random = new Random();
        int numberToGuess = random.Next(1, 101);
        int userGuess = 0;
        int attempts = 0;

        Console.WriteLine("Welcome to the Guessing Game!");
        Console.WriteLine("I have selected a number between 1 and 100. Can you guess it?");

        while (userGuess != numberToGuess)
        {
            Console.Write("Enter your guess: ");
            bool check = int.TryParse(Console.ReadLine(), out userGuess);

            if (!check || userGuess < 1 || userGuess > 100)
            {
                Console.WriteLine("Invalid Input! Please enter a number between 1 and 100.");
                continue;
            }

            attempts++;

            if (userGuess < numberToGuess)
            {
                Console.WriteLine("Too low! Try again.");
            }
            else if (userGuess > numberToGuess)
            {
                Console.WriteLine("Too high! Try again.");
            }
            else
            {
                Console.WriteLine($"Congratulations! You've guessed the number {numberToGuess} in {attempts} attempts.");
            }
        }
    }
}
