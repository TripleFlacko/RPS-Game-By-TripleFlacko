using System;
using System.Drawing;
using System.Net.Http.Headers;

class Program
{
    static void Main()
    {
        const string Rock = "Rock";
        const string Paper = "Paper";
        const string Scissors = "Scissors";

        var playerScore = 0;
        var computerScore = 0;

        while (true)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Choose [r]ock, [p]aper or [s]cissors: ");
            var playerMove = Console.ReadLine();

            if (playerMove == "r" || playerMove == "rock") playerMove = Rock;
            else if (playerMove == "p" || playerMove == "paper") playerMove = Paper;
            else if (playerMove == "s" || playerMove == "scissors") playerMove = Scissors;
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid Input. Try Again...");
                Console.WriteLine();
                continue;
            }

            Random random = new Random();
            var computerRandomNumber = random.Next(1, 4);
            var computerMove = String.Empty;

            switch (computerRandomNumber)
            {
                case 1: computerMove = Rock; break;
                case 2: computerMove = Paper; break;
                case 3: computerMove = Scissors; break;
            }
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"The computer chose {computerMove}.");

            if ((playerMove == Rock && computerMove == Scissors) || (playerMove == Paper && computerMove == Rock) || (playerMove == Scissors && computerMove == Paper))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                playerScore++;
                Console.WriteLine("You win.");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine($"The score is:\nPlayer: {playerScore}\nComputer: {computerScore}");
            }
            else if ((playerMove == Rock && computerMove == Paper) || (playerMove == Paper && computerMove == Scissors) || (playerMove == Scissors && computerMove == Rock))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                computerScore++;
                Console.WriteLine("You lose.");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine($"The score is:\nPlayer: {playerScore}\nComputer: {computerScore}");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("This game was a draw.");
                playerScore++;
                computerScore++;
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine($"The score is:\nPlayer: {playerScore}\nComputer: {computerScore}");
            }

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"If you want to play again, type ""Y"". To quit the game type ""N"":");

            while (true)
            {
                var playersDecision = Console.ReadLine().ToLower();
                Console.WriteLine();
                if (playersDecision == "n" || playersDecision == "no")
                {
                    return;
                }
                else if (playersDecision == "y" || playersDecision == "yes")
                {
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(@"Invalid input. Please type ""Yes"" or ""No""");
                }
            }
        }
    }
}