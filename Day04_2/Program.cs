var cards = File.ReadAllLines("../../../input.txt");

Dictionary<int, int> scratchCardInstances = [];

for (int i = 0; i < cards.Length; i++)
{
    scratchCardInstances.Add(i, 1);
}

for (int i = 0; i < cards.Length; i++)
{
    var card = cards[i];
    var matchingNumbers = 0;

    var allNumbers = card.Split(':')[1];
    var numbers = allNumbers.Split('|');
    var winningNumbers = numbers[0].Split(' ').Where(x => !string.IsNullOrWhiteSpace(x)).ToList();
    var numbersYouHave = numbers[1].Split(' ').Where(x => !string.IsNullOrWhiteSpace(x)).ToList();

    foreach (var numberYouHave in numbersYouHave)
    {
        var isMatchingNumber = winningNumbers.Any(x => x.Equals(numberYouHave));

        if (isMatchingNumber)
        {
            matchingNumbers++;
        }
    }

    for (int j = i + 1; j <= i + matchingNumbers; j++)
    {
        scratchCardInstances[j] += 1 * scratchCardInstances[i];
    }
}

var totalScratchCards = 0;

foreach (var scratchCard in scratchCardInstances)
{
    totalScratchCards += scratchCard.Value;
}

Console.WriteLine(totalScratchCards);