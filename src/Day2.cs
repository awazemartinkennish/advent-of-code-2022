public class Day2
{
    public enum Choice {
        Rock = 1,
        Paper = 2,
        Scissors = 3
    }

    public enum Result {
        Lose = 0,
        Draw = 3,
        Win = 6
    }

    public Choice MapLetter(string letter) => letter switch 
    {
        "X" => Choice.Rock,
        "Y" => Choice.Paper,
        "Z" => Choice.Scissors,
        "A" => Choice.Rock,
        "B" => Choice.Paper,
        "C" => Choice.Scissors,
        _ => throw new InvalidOperationException($"Invalid letter {letter}")
    };

    public Result MapDesiredResult(string letter) => letter switch
    {
        "X" => Result.Lose,
        "Y" => Result.Draw,
        "Z" => Result.Win,
        _ => throw new InvalidOperationException($"Invalid letter {letter}")
    };

    public int CalculateWinner(Choice opponent, Choice player) 
    {
        if (opponent == player) {
            return (int)Result.Draw;
        }

        return (opponent, player) switch 
        {
            (Choice.Rock, Choice.Paper) => (int)Result.Win,
            (Choice.Paper, Choice.Scissors) => (int)Result.Win,
            (Choice.Scissors, Choice.Rock) => (int)Result.Win,
            _ => (int)Result.Lose
        };
    }

    public int ScoreRound(Choice opponent, Choice player) => (int)player + CalculateWinner(opponent, player);


    private Choice WorkOutNeededChoice(Choice opponent, Result desiredResult) => (opponent, desiredResult) switch {
        (Choice.Paper, Result.Lose) => Choice.Rock,
        (Choice.Paper, Result.Draw) => Choice.Paper,
        (Choice.Paper, Result.Win) => Choice.Scissors,

        (Choice.Scissors, Result.Lose) => Choice.Paper,
        (Choice.Scissors, Result.Draw) => Choice.Scissors,
        (Choice.Scissors, Result.Win) => Choice.Rock,

        (Choice.Rock, Result.Lose) => Choice.Scissors,
        (Choice.Rock, Result.Draw) => Choice.Rock,
        (Choice.Rock, Result.Win) => Choice.Paper,

        _ => throw new InvalidOperationException("Nope.")
    };
    
    public int Part1_ScoreGame(string[] rounds) 
    {
        return rounds.Sum(round => PlayRound(round));

        int PlayRound(string round)
        {
            string[] inputs = round.Split(' ');
            Choice opponent = MapLetter(inputs[0]);
            Choice player = MapLetter(inputs[1]);

            return ScoreRound(opponent, player);
        }
    }

    public int Part2_ScoreGame(string[] rounds)
    {
        return rounds.Sum(round => PlayRound(round));

        int PlayRound(string round)
        {
            string[] inputs = round.Split(' ');
            Choice opponent = MapLetter(inputs[0]);
            Result desiredResult = MapDesiredResult(inputs[1]);

            Choice player = WorkOutNeededChoice(opponent, desiredResult);

            int output = (int)player + (int)desiredResult;

            return output;
        }
    }
}