namespace test;

public class Day1Test
{
    private Day1 _sut = new Day1();

    [Fact]
    public void Sample()
    {
        var input = new List<List<int>>()
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

        int expected = 24000;
        int actual = _sut.Execute(input);

        actual.Should().Be(expected);        
    }

    [Fact]
    public void ForReals() 
    {
        string rawInput = File.ReadAllText("./inputs/day1.txt");
        List<List<int>> input = Util.GetInputs(rawInput);

        var actual = _sut.Execute(input);

        actual.Should().Be(69883);
    }
}