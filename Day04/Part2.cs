namespace Day04;

public static class Part2
{
    public static int Calculate(string[] lines)
    {
        var accumulatatedValue = 0;

        foreach (var line in lines)
        {
            var values = line.Split(",");
            var part1 = values[0].Split("-");
            var part2 = values[1].Split("-");

            if (IsBetween(part1[0], part2[0], part2[1]) ||
                IsBetween(part1[1], part2[0], part2[1]) ||
                IsBetween(part2[0], part1[0], part1[1]) ||
                IsBetween(part2[1], part1[0], part1[1]))
                accumulatatedValue++;
        }
        return accumulatatedValue;
    }

    private static bool IsBetween(string value, string start, string stop)
    {
        return int.Parse(value) >= int.Parse(start) && int.Parse(value) <= int.Parse(stop);
    }
}
