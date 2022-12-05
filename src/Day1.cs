namespace src;
public class Day1
{
    public int Execute(List<List<int>> input)
    {
        var elfTotals = input.Select(elf => elf.Sum(foodItemCalories => foodItemCalories));

        return elfTotals.Max();
    }
}
