namespace src;
public class Day4
{
    public int Part1(string[] inputs){
        return inputs.Count(input => ProcessLine(input));
        
        bool ProcessLine(string input)
        {
            // Split the string by , to get the first & second parts
            string[] halves = input.Split(',');

            // Get the range for each part, splitting by - for this
            var range0 = halves[0].Split('-').Select(i => int.Parse(i)).ToArray();
            var range1 = halves[1].Split('-').Select(i => int.Parse(i)).ToArray();

            // return true if range1 is inside range2 OR range2 is inside range1
            return ((range0[0] <= range1[0] && range0[1] >= range1[1]) || (range1[0] <= range0[0] && range1[1] >= range0[1]));
        }
    }

    public int Part2(string[] inputs){
        List<Boolean> outputs = new();
        foreach(string input in inputs)
        {
            outputs.Add(ProcessLine(input));   
        }

        return outputs.Count(o => o);
        
        bool ProcessLine(string input)
        {
            // Split the string by , to get the first & second parts
            string[] halves = input.Split(',');

            // Get the range for each part, splitting by - for this
            var range1 = halves[0].Split('-').Select(i => int.Parse(i)).ToArray();
            var range2 = halves[1].Split('-').Select(i => int.Parse(i)).ToArray();

            // return true if range1 starts inside range2 OR range1 ends inside range2
            return ((range1[0] >= range2[0] && range1[0] < range2[1])
                || (range1[1] <= range2[1] && range1[1] > range2[0])
                || (range2[0] >= range1[0] && range2[0] < range1[1])
                || (range2[1] <= range1[1] && range2[1] > range1[0])
                || (range1[0] == range2[1] || range1[1] == range2[0]));
        }
    }
}