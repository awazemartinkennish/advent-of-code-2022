namespace test;

public class Day1Test
{
    private Day1 _sut = new Day1();

    private List<List<int>> _sampleInput = new List<List<int>>()
        {
          new List<int> {
              1000,
              2000,
              3000,
          },
          new List<int> {
              4000,
          },
          new List<int> {
              5000,
              6000,
          },
          new List<int> {
              7000,
              8000,
              9000,
          },
          new List<int> {
              10000
          }
        };

    [Fact]
    public void Part1_Sample()
    {
        int expected = 24000;
        int actual = _sut.Part1(_sampleInput);

        actual.Should().Be(expected);        
    }

    [Fact]
    public void Part1_ForReals()
    {
        string rawInput = File.ReadAllText("./inputs/day1.txt");
        List<List<int>> input = Util.GetInputs(rawInput);

        var actual = _sut.Part1(input);

        actual.Should().Be(69883);
    }

    [Fact]
    public void Part2_Sample()
    {
        int expected = 45000;
        int actual = _sut.Part2(_sampleInput);

        actual.Should().Be(expected);    
    }

    [Fact]
    public void Part2_ForReals()
    {
        string rawInput = File.ReadAllText("./inputs/day1.txt");
        List<List<int>> input = Util.GetInputs(rawInput);

        var actual = _sut.Part2(input);

        actual.Should().Be(207576);
    }
}