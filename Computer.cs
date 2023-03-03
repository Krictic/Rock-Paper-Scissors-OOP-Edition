namespace RPS
{
    internal class Computer
    {
        private string pcChoice;
        public dynamic rand = new Random();
        public Computer()
        {
            var rand = new Random();
            int rng = rand.Next(1, 9);

            if (rng >= 1 && rng <= 3)
            {
                pcChoice = "rock";
            }
            else if (rng >= 4 && rng <= 6)
            {
                pcChoice = "paper";
            }
            else
            {
                pcChoice = "scissors";
            }
        }
        public string GetPcChoice()
        {
            return pcChoice;
        }

    }
}