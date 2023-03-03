namespace RPS
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            int rounds = 0;
            int playerScore = 0;
            int computerScore = 0;
            int draw = 0;
            
            Console.Write("Choose either rock, paper or scissors: ");
            string? playerChoice = Console.ReadLine().ToLower();

            string[] allowedInputs = { "rock", "paper", "scissors" };
            int pos = Array.IndexOf(allowedInputs, playerChoice);

            if (pos > -1 && playerChoice != null)
            {
                while (rounds < 5)
                {
                    Computer PC = new();
                    StartGame Game = new(playerChoice, PC.GetPcChoice());
                    rounds++;
                    if (Game.RoundResult == "Player Win")
                    {
                        playerScore++;
                        Console.WriteLine("\nPlayer Won a match.");
                    }
                    else if (Game.RoundResult == "Computer Win")
                    {
                        computerScore++;
                        Console.WriteLine("\nComputer Won a match.");
                    }
                    else if (Game.RoundResult == "Draw")
                    {
                        draw++;
                        Console.WriteLine("\nDraw!");
                    }
                    else
                    {
                        Console.WriteLine("Error Check");
                        return;
                    }
                }
                if (playerScore > computerScore )
                {
                    Console.WriteLine("\nPlayer Victory!");
                    Console.WriteLine("\nThe scores were: \nThe player won {0} times. \nThe computer won {1} times. \nThere were {2} draws!", playerScore, computerScore, draw);
                }
                else if (computerScore >= playerScore )
                {
                    Console.WriteLine("\nComputer Victory!");
                    Console.WriteLine("\nThe scores were: \nThe player won {0} times. \nThe computer won {1} times. \nThere were {2} draws!", playerScore, computerScore, draw);
                }
                else
                {
                    Console.WriteLine("\nDraw!");
                    Console.WriteLine("\nThe scores were: \nThe player won {0} times. \nThe computer won {1} times. \nThere were {2} draws!", playerScore, computerScore, draw);
                }
            }
        }
    }
}