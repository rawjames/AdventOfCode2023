using System.Text.RegularExpressions;

namespace AdvertOfCode.Day1.Part1;

public class Day1Part2
{
    public void RunMe()
    {
        var lines = File.ReadAllLines("day1\\day1Input.txt");
        var numbers = "[0-9]|zero|one|two|three|four|five|six|seven|eight|nine";

        int runningTotal = 0;

        foreach (string line in lines)
        {
            Console.WriteLine($"input: {line}");
            var collection = Regex.Matches(line, numbers);
            var first = collection[0].Value;
            var last = collection[^1].Value;

            Console.WriteLine($"first: {first}, last: {last}");

            int number = ParseNumber(first, last);
            Console.WriteLine($"parsed number: {number}");
            runningTotal += number;
        }

        Console.WriteLine($"running total: {runningTotal}");
    }

    private static int ParseNumber(string first, string last)
    {


        int number;
        int.TryParse($"{first}{last}", out number);
        return number;
    }
}