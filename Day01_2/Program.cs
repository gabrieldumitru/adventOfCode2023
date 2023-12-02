Dictionary<string, int> pairs = new Dictionary<string, int>()
{
    { "one", 1 },
    { "two", 2 },
    { "three", 3 },
    { "four", 4 },
    { "five", 5 },
    { "six", 6 },
    { "seven", 7 },
    { "eight", 8 },
    { "nine", 9 },
    { "1", 1 },
    { "2", 2 },
    { "3", 3 },
    { "4", 4 },
    { "5", 5 },
    { "6", 6 },
    { "7", 7 },
    { "8", 8 },
    { "9", 9 },
};

var lines = File.ReadAllLines("input.txt");

var sum = 0;

foreach (var line in lines)
{
    var firstDigitIndex = line.Length;
    var lastDigitIndex = -1;
    var firstDigit = 0;
    var lastDigit = 0;

    foreach (var pair in pairs)
    {
        var pairValueIndex = line.IndexOf(pair.Key);

        if (pairValueIndex != -1)
        {
            if (pairValueIndex < firstDigitIndex)
            {
                firstDigit = pair.Value;
                firstDigitIndex = pairValueIndex;
            }

            pairValueIndex = line.LastIndexOf(pair.Key);

            if (pairValueIndex > lastDigitIndex)
            {
                lastDigit = pair.Value;
                lastDigitIndex = pairValueIndex;
            }
        }
    }

    sum += firstDigit * 10 + lastDigit;
}

Console.WriteLine(sum);