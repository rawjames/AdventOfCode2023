namespace Day2
{
    public record Game
    {
        public int GameId { get; }

        public Draw[] Draws { get; }

        public Game(string line)
        {
            GameId = GetGameId(line);
            Draws = GetDraws(line);
        }

        public bool IsGameValid(int totalRed, int totalGreen, int totalBlue)
        {
            bool valid = Draws.All(d => d.Red <= totalRed && d.Green <= totalGreen && d.Blue <= totalBlue);
            Console.WriteLine($"Draw is valid: {valid}");
            return valid;
        }

        public (int blue, int green, int red) MinimumSetOfCubes()
        {
            var red = Draws.Max(d => d.Red);
            var blue = Draws.Max(d => d.Blue);
            var green = Draws.Max(d => d.Green);

            return (blue, green, red);
        }

        private Draw[] GetDraws(string line)
        {
            Console.WriteLine($"Getting draws for: {line}");
            string[] split = line.Split(":");
            var draws = split[1].Split(";");
            return draws.Select(d => new Draw(d)).ToArray();
        }

        private int GetGameId(string line)
        {
            Console.WriteLine($"Getting game id for: {line}");
            var split = line.Split(":");
            var gameId = split[0].Replace("Game", "");

            Console.WriteLine($"GameID: {gameId}");
            
            return int.Parse(gameId);
        }
    }
}
