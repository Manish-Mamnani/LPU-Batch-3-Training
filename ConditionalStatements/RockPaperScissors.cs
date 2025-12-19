using System;

namespace ConditionalStatements;

public class RockPaperScissors
{
    public void RockMain()
    {
        Console.Write("Player 1 (rock/paper/scissors): ");
        string player1 = Console.ReadLine().ToLower();

        Console.Write("Player 2 (rock/paper/scissors): ");
        string player2 = Console.ReadLine().ToLower();

        if (player1 == player2)
        {
            Console.WriteLine("It's a tie!");
        }
        else if ((player1 == "rock" && player2 == "scissors") ||
                 (player1 == "paper" && player2 == "rock") ||
                 (player1 == "scissors" && player2 == "paper"))
        {
            Console.WriteLine("Player 1 wins!");
        }
        else
        {
            Console.WriteLine("Player 2 wins!");
        }
    }
}
