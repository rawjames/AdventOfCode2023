using System.Text.RegularExpressions;

namespace AdvertOfCode.Day1.Part1;

public class Day1Part1
{
    public void RunMe()
    {
        var lines = File.ReadAllLines("day1Input.txt");
        var numbers = "[0-9]";

        int runningTotal = 0;

        foreach (string line in lines)
        {
            Console.WriteLine($"input: {line}");
            var collection = Regex.Matches(line, numbers);
            var first = collection[0].Value;
            var last = collection[^1].Value;

            Console.WriteLine($"first: {first}, last: {last}");

            int number;
            int.TryParse($"{first}{last}", out number);
            Console.WriteLine($"parsed number: {number}");
            runningTotal += number;
        }

        Console.WriteLine($"running total: {runningTotal}");
    }
}