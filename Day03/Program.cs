string alpha = "abcdefghijklmnopqrstuvwxyz";
char[] chars = (alpha + alpha.ToUpper()).ToCharArray();

var lines = await File.ReadAllLinesAsync("Input.txt");

Console.WriteLine($"Part 1: {Day03.Part1.Calculate(lines, chars)}");

Console.WriteLine($"Part 2: {Day03.Part2.Calculate(lines, chars)}");

Console.ReadKey();
