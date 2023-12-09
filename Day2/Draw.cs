namespace Day2
{
    public record Draw
    {
        public int Blue { get; }
        public int Green { get; }
        public int Red { get; }

        public Draw(string drawLine)
        {
            Console.WriteLine($"Parsing drawline {drawLine}");
            var drawn = drawLine.Split(",");
            foreach (var colour in drawn)
            {
                if(colour.EndsWith("red"))
                {
                    var countString = colour.Replace(" red", string.Empty);
                    Red = int.Parse(countString); 
                }
                if (colour.EndsWith("green"))
                {
                    var countString = colour.Replace(" green", string.Empty);
                    Green = int.Parse(countString);
                }
                if (colour.EndsWith("blue"))
                {
                    var countString = colour.Replace(" blue", string.Empty);
                    Blue = int.Parse(countString);
                }
            }

            Console.WriteLine($"Pase draw: {this}");
        }
    }
}
