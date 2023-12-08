using Day03_1;

var schematic = File.ReadAllLines("../../../input.txt");

var height = schematic.Length;
var width = schematic[0].Length;

var sum = 0;
var currentPart = 0;
var canBeAdded = false;

for (int i = 0; i < height; i++)
{
    for (int j = 0; j < width; j++)
    {
        if (char.IsDigit(schematic[i][j]))
        {
            var digitValue = int.Parse(schematic[i][j].ToString());
            currentPart = currentPart * 10 + digitValue;

            foreach (var neighbour in Neighbours.neighbours)
            {
                // check if neighbour is out of schematic
                if (i + neighbour.y < 0 || i + neighbour.y >= width || j + neighbour.x >= height || j + neighbour.x < 0) continue;

                var neighbourValue = schematic[i + neighbour.y][j + neighbour.x];

                if (!char.IsDigit(neighbourValue) && neighbourValue != '.')
                {
                    canBeAdded = true;
                }
            }
        }
        else
        {
            AddNumberIfCanBeAdded();
        }
    }

    AddNumberIfCanBeAdded();
}

Console.WriteLine(sum);

void AddNumberIfCanBeAdded()
{
    if (currentPart != 0 && canBeAdded)
    {
        Console.WriteLine(currentPart);
        sum += currentPart;
    }
    currentPart = 0;
    canBeAdded = false;
}