namespace Day07;

public static class Part1
{
    public static long Calculate(string[] lines)
    {
        var directoryTree = new Stack<string>();

        Dictionary<string, long> directorySummary = new();

        foreach (var line in lines)
        {
            var parts = line.Split(" ");
            
            if (parts[0].StartsWith("$"))
            {
                //Change directory;
                if (parts[1] == "cd")
                {
                    if (parts[2] == "..")
                    {
                        directoryTree.Pop();
                    }
                    else
                    {
                        //Subdirectory-names aren't unique, add uniqueness
                        directoryTree.Push(string.Join("/", directoryTree.Reverse()) + parts[2]);
                    }
                }
                continue;
            }
            
            else if (parts[0].StartsWith("dir"))
                continue;

            else if (int.TryParse(parts[0], out int size))
            {
                foreach (string directory in directoryTree)
                {
                    if (!directorySummary.ContainsKey(directory))
                        directorySummary[directory] = 0;

                    directorySummary[directory] += size;
                }
            }
        }

        var validDirectories = directorySummary.Where(x => x.Value <= 100000).ToList();
        return validDirectories.Sum(x => x.Value);
    }
}
