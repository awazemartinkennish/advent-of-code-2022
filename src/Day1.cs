namespace src;
public class Day1
{
    public int Part1(List<List<int>> input)
    {
        var elfTotals = input.Select(elf => elf.Sum(foodItemCalories => foodItemCalories));

        return elfTotals.Max();
    }

    public int Part2(List<List<int>> input)
    {
        var elfTotals = input.Select(elf => elf.Sum());

        return elfTotals.OrderByDescending(t => t).Take(3).Sum();
    }
}
