namespace test;

public class Day4Test
{
    Day4 _sut = new Day4();

    string[] _sampleInput = new string[] {
        "2-4,6-8",
        "2-3,4-5",
        "5-7,7-9",
        "2-8,3-7",
        "6-6,4-6",
        "2-6,4-8",
    };

    [Fact]
    public void Part1_Sample()
    {
        int expected = 2;
        int actual = _sut.Part1(_sampleInput);

        actual.Should().Be(expected);   
    }

    [Fact]
    public void Part1_Data()
    {
        string[] inputs = File.ReadAllLines("./inputs/day4.txt");

        int expected = 464;
        int actual = _sut.Part1(inputs);

        actual.Should().Be(expected);
    }

    [Fact]
    public void Part2_Sample()
    {
        int expected = 4;
        int actual = _sut.Part2(_sampleInput);

        actual.Should().Be(expected); 
    }


    [Fact]
    public void Part2_Data()
    {
        string[] inputs = File.ReadAllLines("./inputs/day4.txt");

        int expected = 770;
        int actual = _sut.Part2(inputs);

        actual.Should().Be(expected);
    }
}
