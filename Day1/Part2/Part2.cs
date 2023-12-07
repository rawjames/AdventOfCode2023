using System.Text.RegularExpressions;

namespace AdvertOfCode.Day1.Part1;

public class Day1Part2
{
    public void RunMe()
    {
        var lines = File.ReadAllLines("day1Input.txt");
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