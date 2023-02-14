using System;

namespace RockPapersScissorsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rock - Papers - Scissors Game

            Random random = new Random();
            bool playAgain = true;
            String player;
            String answer;
            String computer;

            while (playAgain)
            {
                player = "";
                computer = "";
                answer = "";

            while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
            {
                Console.WriteLine("Enter ROCK, PAPER, or SCISSORS: ");
                player = Console.ReadLine();
                player = player.ToUpper();
            }


            switch (random.Next(1, 4))
            {
                case 1:
                    computer = "ROCK";
                    break;
                case 2:
                    computer = "PAPER";
                    break;
                case 3:
                    computer = "SCISSORS";
                    break;
            }

            Console.WriteLine("Player: " + player);
            Console.WriteLine("Computer: " + computer);

            switch (player)
            {
                case "ROCK":
                    if (computer == "ROCK")
                    {
                        Console.WriteLine("It's a draw!");
                    }
                    else if (computer == "PAPER")
                    {
                        Console.WriteLine("You Lose!");
                    }
                    else
                    {
                        Console.WriteLine("YOU WIN!!!");
                    }
                    break;
                case "PAPER":
                    if (computer == "PAPER")
                    {
                        Console.WriteLine("It's a draw!");
                    }
                    else if (computer == "SCISSORS")
                    {
                        Console.WriteLine("You Lose!");
                    }
                    else
                    {
                        Console.WriteLine("YOU WIN!!!");
                    }
                    break;
                case "SCISSORS":
                    if (computer == "SCISSORS")
                    {
                        Console.WriteLine("It's a draw!");
                    }
                    else if (computer == "ROCK")
                    {
                        Console.WriteLine("You Lose!");
                    }
                    else
                    {
                        Console.WriteLine("YOU WIN!!!");
                    }
                    break;
                   
            }
            Console.WriteLine("\n\n\n\n\n");
            Console.WriteLine("Would you like to play again (Y/N)");
            answer = Console.ReadLine();
            answer = answer.ToUpper();

            if (answer == "Y")
            {
                playAgain = true;
            }
            else
            {
                Console.WriteLine("\n\n\n\n\n");
                playAgain = false;
            }

            }
            Console.WriteLine("Thanks for playing!!");

            Console.ReadKey();

        }
    }
}