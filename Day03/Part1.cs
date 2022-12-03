namespace Day03;

public static class Part1
{
    private static readonly List<char> values = new() { '0', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

    public static int Calculate(string[] lines)
    {
        var accumulatatedValue = 0;

        foreach (var line in lines)
        {
            var length = line.Length / 2;
            var part1 = line.Take(length).ToArray();
            var part2 = line[length..].ToCharArray();

            foreach(var c in  part1)
            {
                if(part2.Contains(c))
                {
                    accumulatatedValue += values.IndexOf(c);
                    break;
                }
            }            
        }

        return accumulatatedValue;
    }
}
