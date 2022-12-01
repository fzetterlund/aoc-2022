var lines = await File.ReadAllLinesAsync("Input.txt");

int index = 0;
List<int> values = new() { 0 };

foreach (var line in lines)
{
    if (!string.IsNullOrWhiteSpace(line))
    {
        values[index] += int.Parse(line);
    }
    else
    {
        values.Add(0);
        index++;
    }
}

Console.WriteLine($"Part 1: {values.Max()}");

Console.WriteLine($"Part 2:  {values.OrderByDescending(x => x).Take(3).Sum()}");

Console.ReadKey();