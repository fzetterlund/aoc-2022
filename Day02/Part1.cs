namespace Day02;

public static class Part1
{
    const int Win = 6;
    const int Draw = 3;
    const int Loose = 0;

    const string OpponentRock = "A";
    const string OpponentPaper = "B";
    const string OpponentScissors = "C";

    const string Rock = "X";
    const string Paper = "Y";
    const string Scissors = "Z";

    private static Dictionary<string, int> selectionScores = new()
    {
        { Rock, 1 },
        { Paper, 2 },
        { Scissors, 3 },
    };

    private static Dictionary<string, int> outcomeScoresMap = new()
    {
        { $"{OpponentRock} {Scissors}", Loose },
        { $"{OpponentRock} {Rock}", Draw },
        { $"{OpponentRock} {Paper}", Win },
        { $"{OpponentPaper} {Rock}", Loose },
        { $"{OpponentPaper} {Paper}", Draw },
        { $"{OpponentPaper} {Scissors}", Win },
        { $"{OpponentScissors} {Paper}", Loose },
        { $"{OpponentScissors} {Scissors}", Draw },
        { $"{OpponentScissors} {Rock}", Win },
    };

    public static int Calculate(string[] rounds)
    {
        var accumulatedScore = 0;

        foreach (var round in rounds)
        {
            var choices = round.Split(" ");

            var selectedScore = selectionScores[choices[1]];

            var outcomeScore = outcomeScoresMap[round];

            accumulatedScore += selectedScore + outcomeScore;
        }

        return accumulatedScore;
    }
}
