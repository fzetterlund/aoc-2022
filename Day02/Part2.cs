namespace Day02;

public static class Part2
{
    const string Win = "Z";
    const string Draw = "Y";
    const string Loose = "X";

    const string OpponentRock = "A";
    const string OpponentPaper = "B";
    const string OpponentScissors = "C";

    const int Rock = 1;
    const int Paper = 2;
    const int Scissors = 3;

    private static Dictionary<string, int> selectedScoresMap = new()
    {
        { $"{OpponentRock} {Win}", Paper },
        { $"{OpponentRock} {Loose}", Scissors },
        { $"{OpponentRock} {Draw}", Rock },
        { $"{OpponentPaper} {Win}", Scissors },
        { $"{OpponentPaper} {Loose}", Rock },
        { $"{OpponentPaper} {Draw}", Paper },
        { $"{OpponentScissors} {Win}", Rock },
        { $"{OpponentScissors} {Loose}", Paper },
        { $"{OpponentScissors} {Draw}", Scissors },
    };

    public static int Calculate(string[] rounds)
    {
        var accumulatedScore = 0;

        foreach (var round in rounds)
        {
            var choices = round.Split(" ");

            var selectedScore = selectedScoresMap[round];

            var outcomeScore = choices[1] switch
            {
                "X" => 0,
                "Y" => 3,
                "Z" => 6,
                _ => throw new ArgumentException("Invalid choice")
            };

            accumulatedScore += selectedScore + outcomeScore;
        }

        return accumulatedScore;
    }
}
