namespace Day05;

public static class Part2
{
    public static string Calculate(string[] lines)
    {
        Dictionary<int, List<string>> items = new();
        Dictionary<int, Stack<string>> stacks = new();

        var header = lines.TakeWhile(x => !string.IsNullOrWhiteSpace(x)).ToList();
        var commands = lines.Skip(header.Count + 1);

        foreach (var line in header.SkipLast(1))
        {
            int stack = 1;
            int i = 1;
            while (i < line.Length)
            {
                var stackValue = line.Substring(i, 1);
                if (!string.IsNullOrWhiteSpace(stackValue))
                {
                    if (!items.ContainsKey(stack))
                        items.Add(stack, new List<string>());
                    items[stack].Add(stackValue);
                }
                i += 4;
                stack++;
            }
        }

        foreach (var item in items)
        {
            item.Value.Reverse();
            stacks.Add(item.Key, new(item.Value));
        }

        foreach (var command in commands)
        {
            var parts = command.Split(" ");

            int count = int.Parse(parts[1]);
            int from = int.Parse(parts[3]);
            int to = int.Parse(parts[5]);

            int i = 0;

            List<string> moveList = new();
            while (i < count)
            {
                moveList.Add(stacks[from].Pop());
                i++;
            }

            moveList.Reverse();
            foreach (var item in moveList)
                stacks[to].Push(item);
        }

        return string.Join(string.Empty, stacks.OrderBy(x => x.Key).Select(x => x.Value.Pop()));
    }
}
