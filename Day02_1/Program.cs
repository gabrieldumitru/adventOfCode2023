var games = File.ReadAllLines("../../../input.txt");

var sum = 0;

const int MaxRed = 12;
const int MaxGreen = 13;
const int MaxBlue = 14;

foreach (var game in games)
{
    var indexAndSets = game.Split(':');
    var gameIndex = indexAndSets[0].Split(' ')[1];

    var sets = indexAndSets[1].Split(';');

    var isPossible = true;

    foreach (var set in sets)
    {
        var cubeReveals = set.Split(',');

        foreach (var cubeReveal in cubeReveals)
        {
            var cubeRevealPair = cubeReveal.Trim().Split(' ');
            switch (cubeRevealPair[1])
            {
                case "red":
                    if (Convert.ToInt32(cubeRevealPair[0]) > MaxRed)
                    {
                        isPossible = false;
                    }
                    break;

                case "green":
                    if (Convert.ToInt32(cubeRevealPair[0]) > MaxGreen)
                    {
                        isPossible = false;
                    }
                    break;

                case "blue":
                    if (Convert.ToInt32(cubeRevealPair[0]) > MaxBlue)
                    {
                        isPossible = false;
                    }
                    break;
            }
        }
    }

    if (isPossible) sum += Convert.ToInt32(gameIndex);
}

Console.WriteLine(sum);