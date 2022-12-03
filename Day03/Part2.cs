namespace Day03;

public static class Part2
{
    private static readonly List<char> values = new() { '0', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

    public static int Calculate(string[] lines)
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
                if(line2.Contains(c) && line3.Contains(c))                
                {
                    accumulatatedValue += values.IndexOf(c);
                    index += 3;
                    break;
                }
            }
        }

        return accumulatatedValue;
    }
}
