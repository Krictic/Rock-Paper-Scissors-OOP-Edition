using System.Security;

namespace RPS
{
    internal class PlayRound
    {
        public string GetRound(string playerSelection, string computerSelection)
        {
            if (playerSelection == computerSelection)
            {
                return "Draw";
            }
            else if (playerSelection == "rock" && computerSelection == "paper")
            {
                return "Computer Win";
            }
            else if (playerSelection == "paper" && computerSelection == "rock")
            {
                return "Player Win";
            }
            else if (playerSelection == "scissors" && computerSelection == "paper")
            {
                return "Player Win";
            }
            else if (playerSelection == "paper" && computerSelection == "scissors")
            {
                return "Computer Win";
            }
            else if (playerSelection == "scissors" && computerSelection == "rock")
            {
                return "Computer Win";
            }
            else if (playerSelection == "rock" && computerSelection == "scissors")
            {
                return "Player Win";
            }
            else
            {
                return "";
            }
        }


    }
}