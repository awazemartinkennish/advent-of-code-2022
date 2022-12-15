/*
vJrwpWtwJgWrhcsFMMfFFhFp
jqHRNqRjqzjGDLGLrsFMfFZSrLrFZsSL
PmmdzqPrVvPwwTWBwg
wMqvLMZHhHMvwLHjbvcjnnSBnvTQFn
ttgJtRGJQctTZtZT
CrZsJsPPZsGzwwsLwLmpwMDw
*/

namespace test;

public class Day3Test
{
    Day3 _sut = new Day3();

    string[] _sampleInput = new string[] {
        "vJrwpWtwJgWrhcsFMMfFFhFp",
        "jqHRNqRjqzjGDLGLrsFMfFZSrLrFZsSL",
        "PmmdzqPrVvPwwTWBwg",
        "wMqvLMZHhHMvwLHjbvcjnnSBnvTQFn",
        "ttgJtRGJQctTZtZT",
        "CrZsJsPPZsGzwwsLwLmpwMDw"
    };

    [Fact]
    public void Part1_Sample()
    {
        int expected = 157;
        int actual = _sut.Part1(_sampleInput);

        actual.Should().Be(expected);   
    }

    [Fact]
    public void Part1_Data()
    {
        string[] inputs = File.ReadAllLines("./inputs/day3.txt");

        int expected = 7553;
        int actual = _sut.Part1(inputs);

        actual.Should().Be(expected);
    }

    [Fact]
    public void Part2_Sample()
    {
        int expected = 70;
        int actual = _sut.Part2(_sampleInput);

        actual.Should().Be(expected); 
    }


    [Fact]
    public void Part2_Data()
    {
        string[] inputs = File.ReadAllLines("./inputs/day3.txt");

        int expected = 2758;
        int actual = _sut.Part2(inputs);

        actual.Should().Be(expected);
    }
}
