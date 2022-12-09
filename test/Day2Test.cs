namespace test;

public class Day2Test
{
    Day2 _sut = new Day2();

    string[] _sampleInput = new string[] {
        "A Y",
        "B X",
        "C Z"
    };

    [Fact]
    public void Part1_Sample()
    {
        int expected = 15;
        int actual = _sut.Part1_ScoreGame(_sampleInput);

        actual.Should().Be(expected);        
    }

    [Fact]
    public void Part1_Data()
    {
        string[] inputs = File.ReadAllLines("./inputs/day2.txt");

        int expected = 11449;
        int actual = _sut.Part1_ScoreGame(inputs);

        actual.Should().Be(expected);
    }

    [Fact]
    public void Part2_Sample()
    {
        int expected = 12;
        int actual = _sut.Part2_ScoreGame(_sampleInput);

        actual.Should().Be(expected);
    }

    [Fact]
    public void Part2_Data()
    {
        string[] inputs = File.ReadAllLines("./inputs/day2.txt");

        int expected = 13187;
        int actual = _sut.Part2_ScoreGame(inputs);

        actual.Should().Be(expected);
    }
}