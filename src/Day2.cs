public class Day2
{
    public enum Choice {
        Rock = 1,
        Paper = 2,
        Scissors = 3
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

    public int CalculateWinner(Choice opponent, Choice player) 
    {
        const int win = 6;
        const int draw = 3;
        const int lose = 0;

        if (opponent == player) {
            return draw;
        }

        return (opponent, player) switch 
        {
            (Choice.Rock, Choice.Paper) => win,
            (Choice.Paper, Choice.Scissors) => win,
            (Choice.Scissors, Choice.Rock) => win,
            _ => lose
        };
    }

    public int ScoreRound(Choice opponent, Choice player) => (int)player + CalculateWinner(opponent, player);

    public int PlayRound(string round)
    {
        string[] inputs = round.Split(' ');
        Choice opponent = MapLetter(inputs[0]);
        Choice player = MapLetter(inputs[1]);

        return ScoreRound(opponent, player);
    }

    public int ScoreGame(string[] rounds) 
    {
        return rounds.Sum(round => PlayRound(round));
    }
}