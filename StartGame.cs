namespace RPS
{
    internal class StartGame
    {

        
        private string player;
        private string computer;
        public string RoundResult;

        public StartGame(string playerChoice, string computerChoice)
        {
            player = playerChoice;
            computer = computerChoice;

            PlayRound round = new PlayRound();
            RoundResult = round.GetRound(player, computer);

        }
        
        public string getPlayer()
        {
            return player;
        }

        public string getComputer()
        {
            return computer;
        }
    }
}