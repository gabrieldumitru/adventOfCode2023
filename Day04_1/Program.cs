var cards = File.ReadAllLines("../../../input.txt");

var totalPoints = 0;

foreach (var card in cards)
{
    var cardPoints = 0;

    var allNumbers = card.Split(':')[1];
    var numbers = allNumbers.Split('|');
    var winningNumbers = numbers[0].Split(' ').Where(x => !string.IsNullOrWhiteSpace(x)).ToList();
    var numbersYouHave = numbers[1].Split(' ').Where(x => !string.IsNullOrWhiteSpace(x)).ToList();

    bool isFirst = true;

    foreach (var numberYouHave in numbersYouHave)
    {
        var isWinningNumber = winningNumbers.Any(x => x.Equals(numberYouHave));

        if (isWinningNumber && isFirst)
        {
            cardPoints++;
            isFirst = false;
        }
        else if (isWinningNumber)
        {
            cardPoints *= 2;
        }
    }

    totalPoints += cardPoints;
}

Console.WriteLine(totalPoints);