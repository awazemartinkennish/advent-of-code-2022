public class MyClass
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
        int actual = _sut.ScoreGame(_sampleInput);

        actual.Should().Be(expected);        
    }

    [Fact]
    public void Part2_Data()
    {
        string[] inputs = File.ReadAllLines("./inputs/day2.txt");

        int expected = 11449;
        int actual = _sut.ScoreGame(inputs);

        actual.Should().Be(expected);
    }
}