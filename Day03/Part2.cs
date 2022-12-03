namespace Day03;

public static class Part2
{
    public static int Calculate(string[] lines, char[] chars)
    {
        var accumulatatedValue = 0;
        var index = 0;
        while (index < lines.Length)
        {
            var line1 = lines[index].ToCharArray();
            var line2 = lines[index + 1].ToCharArray();
            var line3 = lines[index + 2].ToCharArray();

            foreach (char c in line1)
            {
                if (line2.Contains(c) && line3.Contains(c))
                {
                    accumulatatedValue += Array.IndexOf(chars, c) + 1;
                    index += 3;
                    break;
                }
            }
        }

        return accumulatatedValue;
    }
}
