namespace Day2
{
    internal class Part1
    {
        public void RunMe()
        {      
            const string fileName = "Day2Input.txt";

            var lines = File.ReadAllLines(fileName);

            var games = lines.Select(l => new Game(l));
            var totalCount = games.Where(g => g.IsGameValid(12, 13, 14)).Sum(g => g.GameId);

            Console.WriteLine($"Combine count: {totalCount}");
        }
    }
}
