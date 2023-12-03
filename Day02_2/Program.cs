var games = File.ReadAllLines("../../../input.txt");

var sum = 0;

foreach (var game in games)
{
    var minRed = 0;
    var minGreen = 0;
    var minBlue = 0;

    var indexAndSets = game.Split(':');
    var gameIndex = indexAndSets[0].Split(' ')[1];

    var sets = indexAndSets[1].Split(';');

    foreach (var set in sets)
    {
        var cubeReveals = set.Split(',');

        foreach (var cubeReveal in cubeReveals)
        {
            var cubeRevealPair = cubeReveal.Trim().Split(' ');
            switch (cubeRevealPair[1])
            {
                case "red":
                    var redCubes = Convert.ToInt32(cubeRevealPair[0]);
                    if (redCubes > minRed)
                    {
                        minRed = redCubes;
                    }
                    break;

                case "green":
                    var greenCubes = Convert.ToInt32(cubeRevealPair[0]);
                    if (greenCubes > minGreen)
                    {
                        minGreen = greenCubes;
                    }
                    break;

                case "blue":
                    var blueCubes = Convert.ToInt32(cubeRevealPair[0]);
                    if (blueCubes > minBlue)
                    {
                        minBlue = blueCubes;
                    }
                    break;
            }
        }
    }

    var power = minRed * minGreen * minBlue;

    sum += power;
}

Console.WriteLine(sum);