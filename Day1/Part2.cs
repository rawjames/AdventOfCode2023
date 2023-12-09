using System.Text.RegularExpressions;

namespace Day1;

public class Day1Part2
{
    public void RunMe()
    {
        var lines = File.ReadAllLines("day1Input.txt");

        int runningTotal = 0;
        var regEx = new Regex("[0-9]|zero|one|two|three|four|five|six|seven|eight|nine");

        foreach (string line in lines)
        {
            Console.WriteLine($"input: {line}");
            var match = regEx.Match(line);
            var first = match.Value;
            var last = FindLastMatch(regEx, line);

            Console.WriteLine($"first: {first}, last: {last}");

            int number = ParseNumber(first, last);
            Console.WriteLine($"parsed number: {number}");
            runningTotal += number;
        }

        Console.WriteLine($"running total: {runningTotal}");
    }

    private string FindLastMatch(Regex regEx, string line)
    {
        string compare = string.Empty;
        for (int i = line.Length - 1; i >= 0; i--)
        {
            compare = line[i] + compare;
            var match = regEx.Match(compare);
            if (match.Success)
            {
                return match.Value;
            }
        }

        return string.Empty;
    }

    private static int ParseNumber(string first, string last)
    {
        first = ConvertToNumber(first);
        last = ConvertToNumber(last);
        int number;
        int.TryParse($"{first}{last}", out number);
        return number;
    }

    private static string ConvertToNumber(string number)
    {
        switch (number)
        {
            case "zero":
                return "0";
            case "one":
                return "1";
            case "two":
                return "2";
            case "three":
                return "3";
            case "four":
                return "4";
            case "five":
                return "5";
            case "six":
                return "6";
            case "seven":
                return "7";
            case "eight":
                return "8";
            case "nine":
                return "9";
        }
        return number;
    }
}