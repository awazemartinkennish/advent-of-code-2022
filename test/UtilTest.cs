namespace test;

public class UtilTest
{
    [Fact]
    public void Sample()
    {
        string input = @"100
200

300

400
500
600";

        var expected = new List<List<int>>{
            new List<int>{100, 200},
            new List<int>{300},
            new List<int>{400,500,600}
        };

        var actual = Util.GetInputs(input);

        actual.Should().BeEquivalentTo(expected);    
    }
}