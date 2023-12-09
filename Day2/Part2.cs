namespace AdventOfCode.Day2
{
    internal class Part2
    {
        public void RunMe()
        {
            const string fileName = "Day2Input.txt";

            var lines = File.ReadAllLines(fileName);

            var games = lines.Select(l => new Game(l));
            var total = games.Sum(g =>
            {
                var miniumCubes = g.MinimumSetOfCubes();
                Console.WriteLine($"Minimum cubes {miniumCubes}");
                var power = miniumCubes.red * miniumCubes.green * miniumCubes.blue;
                return power;
            });

            Console.WriteLine($"Combine count: {total}");
        }
    }
}
