namespace src;
public class Day3
{
    private Dictionary<char, int> characterMap = new()
    {
        {'a', 1},
        {'b', 2},
        {'c', 3},
        {'d', 4},
        {'e', 5},
        {'f', 6},
        {'g', 7},
        {'h', 8},
        {'i', 9},
        {'j', 10},
        {'k', 11},
        {'l', 12},
        {'m', 13},
        {'n', 14},
        {'o', 15},
        {'p', 16},
        {'q', 17},
        {'r', 18},
        {'s', 19},
        {'t', 20},
        {'u', 21},
        {'v', 22},
        {'w', 23},
        {'x', 24},
        {'y', 25},
        {'z', 26},
        {'A', 27},
        {'B', 28},
        {'C', 29},
        {'D', 30},
        {'E', 31},
        {'F', 32},
        {'G', 33},
        {'H', 34},
        {'I', 35},
        {'J', 36},
        {'K', 37},
        {'L', 38},
        {'M', 39},
        {'N', 40},
        {'O', 41},
        {'P', 42},
        {'Q', 43},
        {'R', 44},
        {'S', 45},
        {'T', 46},
        {'U', 47},
        {'V', 48},
        {'W', 49},
        {'X', 50},
        {'Y', 51},
        {'Z', 52}
    };

    public int Part1(string[] input)
    {
        return input.Sum(l => ProcessLine(l));

        int ProcessLine(string line)
        {
            string firstHalf = line.Substring(0, line.Length / 2);
            string secondHalf = line.Substring(line.Length / 2);

            foreach (char c1 in firstHalf)
            {
                if (secondHalf.Contains(c1))
                {
                    return characterMap[c1];
                }
            }

            throw new InvalidOperationException("no matching characters");
        }
    }

    public int Part2(string[] input)
    {
        int output = 0;
        for (int i = 0; i < input.Length; i += 3)
        {
            output += ProcessLines(input.Skip(i).Take(3).ToArray());
        }

        return output;
        
        int ProcessLines(string[] lines) 
        {
            foreach (char c1 in lines[0]) 
            {
                if (lines[1].Contains(c1) && lines[2].Contains(c1))
                {
                    return characterMap[c1];
                }
            }   

            throw new InvalidOperationException("No matching characters"); 
        }
    }
}
