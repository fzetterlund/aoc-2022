namespace Day03;

public static class Part1
{
    public static int Calculate(string[] lines, char[] chars)
    {
        var accumulatatedValue = 0;

        foreach (var line in lines)
        {
            var length = line.Length / 2;
            var part1 = line.Take(length).ToArray();
            var part2 = line[length..].ToCharArray();

            foreach (var c in part1)
            {
                if (part2.Contains(c))
                {
                    accumulatatedValue += Array.IndexOf(chars, c) + 1;
                    break;
                }
            }
        }

        return accumulatatedValue;
    }
}
