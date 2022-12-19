namespace src;
public class Day5
{
    public (List<string> boxes, List<string> instructions) SeparateBoxesAndInstructions(string[] inputs)
    {
        List<string> boxes = new();
        List<string> instructions = new();
        bool isInstructions = false;

        foreach (string input in inputs)
        {
            // if it's the empty line go to boxes mode and stop processing line
            if (input == string.Empty)
            {
                isInstructions = true;
                boxes = boxes.Take(boxes.Count - 1).ToList();
                break;
            }

            if (isInstructions)
            {
                instructions.Add(input);
            }
            else
            {
                boxes.Add(input);
            }
        }

        return (boxes, instructions);
    }

    // "    [D]    ",
    // "[N] [C]    ",
    // "[Z] [M] [P]",
    public List<List<char>> ParseBoxes(List<string> boxes)
    {
        int rowWidth = boxes[0].Length;
        int items = (rowWidth / 4) + 1;

        List<List<char>> output = Enumerable.Range(0, items).Select(_ => new List<char>()).ToList();

        boxes.Reverse();
        
        foreach (string rowString in boxes)
        {
            var row = ParseRow(rowString, items);
            for (int j = 0; j < items; j++)
            {
                if (row[j] != null)
                {
                    output[j].Add((char)row[j]);
                }
            }
        }

        return output;

        List<char?> ParseRow(string row, int itemCount)
        {
            List<char?> output = new();
            for (int i = 0; i < items; i++)
            {
                char box = row[(4 * i) + 1];

                if (char.IsWhiteSpace(box))
                {
                    output.Add(null);
                }
                else
                {
                    output.Add(box);
                }
            }

            return output;
        }
    }

    public string Part1(string[] inputs)
    {
        // Find the boxes and instructions
        (List<string> boxes, List<string> instructions) = SeparateBoxesAndInstructions(inputs);

        // Represent the boxes as a structure
        List<List<char>> startState = ParseBoxes(boxes);
        // Execute the instructions on the boxes
        // report the top boxes


        return string.Empty;
    }
}
