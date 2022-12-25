namespace src;
public class Day5
{
    public (List<string> boxes, List<string> instructionsRaw) SeparateBoxesAndInstructions(string[] inputs)
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
                continue;
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

    record Instruction(int numberToMove, int source, int destination)
    {
        public int Source => this.source - 1;
        public int Destination => this.destination - 1;
    }

    void ExecuteInstruction(Instruction instruction, List<List<char>> state)
    {
        for(int i=0; i< instruction.numberToMove; i++)
        {
            char itemToMove = state[instruction.Source][state[instruction.Source].Count - 1];
            state[instruction.Source].RemoveAt(state[instruction.Source].Count - 1);
            state[instruction.Destination].Add(itemToMove);
        }
    }

    string PrintTopRow(List<List<char>> state) => state.Select(row => row[row.Count - 1])
            .Aggregate("", (total, box) => total += box);

    public string Part1(string[] inputs)
    {
        // Find the boxes and instructions
        (List<string> boxes, List<string> instructionsRaw) = SeparateBoxesAndInstructions(inputs);

        // Represent the boxes as a structure
        List<List<char>> state = ParseBoxes(boxes);
        // Execute the instructions on the boxes
        var instructions = instructionsRaw.Select(i => {
            //"move 1 from 2 to 1"
            string[] parts = i.Split(' ');
            return new Instruction(int.Parse(parts[1]), int.Parse(parts[3]), int.Parse(parts[5]));
        }).ToList();

        foreach(Instruction instruction in instructions)
        {
            ExecuteInstruction(instruction, state);
        }

        // report the top boxes
        return PrintTopRow(state);
    }
}
