namespace Day04;

public static class Part1
{
    public static int Calculate(string[] lines)
    {
        var accumulatatedValue = 0;

        foreach (var line in lines)
        {
            var values = line.Split(",");
            var part1 = values[0].Split("-");
            var part2 = values[1].Split("-");

            if ((int.Parse(part1[0]) >= int.Parse(part2[0]) && int.Parse(part1[1]) <= int.Parse(part2[1])) ||
                (int.Parse(part2[0]) >= int.Parse(part1[0]) && int.Parse(part2[1]) <= int.Parse(part1[1])))
                accumulatatedValue++;
        }
        return accumulatatedValue;
    }
}
