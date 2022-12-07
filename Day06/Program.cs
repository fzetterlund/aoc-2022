int Calculate(string text, int count)
{
    var queue = new List<char>(count);
    for (int i = 0; i < count; i++)
        queue.Add(' ');

    int index = 0;
    foreach (var charecter in text)
    {
        queue.RemoveAt(0);
        queue.Add(charecter);
        index++;
        if (index >= count && queue.GroupBy(x => x).Count() >= count)
            return index;

    }
    return index;
}

var lines = await File.ReadAllTextAsync("Input.txt");

Console.WriteLine($"Part 1: {Calculate(lines, 4)}");
Console.WriteLine($"Part 2: {Calculate(lines, 14)}");

Console.ReadKey();
