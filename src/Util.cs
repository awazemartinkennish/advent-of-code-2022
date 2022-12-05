public static class Util
{
     public static List<List<int>> GetInputs(string raw)
    {
        List<string> rows = raw.Split('\n').ToList();

        List<List<int>> output = new();
        List<int> interim = new();

        foreach (string row in rows)
        {
            if (row == string.Empty) 
            {
                output.Add(interim);
                interim = new();
            } else {
                interim.Add(int.Parse(row));
            }
        }

        output.Add(interim);

        return output;
    }
}