
var lines = await File.ReadAllLinesAsync("Input.txt");

Console.WriteLine($"Part 1: {Day04.Part1.Calculate(lines)}");

Console.WriteLine($"Part 2: {Day04.Part2.Calculate(lines)}");

Console.ReadKey();