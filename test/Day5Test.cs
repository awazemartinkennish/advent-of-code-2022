namespace test;

public class Day5Test
{
    Day5 _sut = new Day5();

    string[] _sampleInput = new string[] {
        "    [D]    ",
        "[N] [C]    ",
        "[Z] [M] [P]",
        " 1   2   3 ",
        "",
        "move 1 from 2 to 1",
        "move 3 from 1 to 3",
        "move 2 from 2 to 1",
        "move 1 from 1 to 2",
    };

    [Fact]
    public void ParseBoxes()
    {
        (List<string> boxes, List<string> _) = _sut.SeparateBoxesAndInstructions(_sampleInput);
        List<List<char>> actual = _sut.ParseBoxes(boxes);
        List<List<char>> expected = new()
        {
            new() {'Z', 'N'},
            new() {'M', 'C', 'D'},
            new() {'P'}
        };

        actual.Should().BeEquivalentTo(expected);
    }

    [Fact]
    public void Part1_Sample()
    {
        string expected = "CMZ";
        string actual = _sut.Part1(_sampleInput);

        actual.Should().Be(expected);   
    }

    // [Fact]
    // public void Part1_Data()
    // {
    //     string[] inputs = File.ReadAllLines("./inputs/day4.txt");

    //     string expected = "CMZ";
    //     string actual = _sut.Part1(inputs);

    //     actual.Should().Be(expected);
    // }

    // [Fact]
    // public void Part2_Sample()
    // {
    //     int expected = 4;
    //     int actual = _sut.Part2(_sampleInput);

    //     actual.Should().Be(expected); 
    // }


    // [Fact]
    // public void Part2_Data()
    // {
    //     string[] inputs = File.ReadAllLines("./inputs/day4.txt");

    //     int expected = 0;
    //     int actual = _sut.Part2(inputs);

    //     actual.Should().Be(expected);
    // }
}
