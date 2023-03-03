namespace RPS
{
    internal class Player
    {
        public Player(string? Choice) => RPSChoice = Choice;

        public string RPSChoice { get; set; }
    }
}