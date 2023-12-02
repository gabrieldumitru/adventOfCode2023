using System.Globalization;

var lines = File.ReadAllLines("input.txt");

var sum = 0;

foreach (var line in lines)
{
    var firstDigit = CharUnicodeInfo.GetDecimalDigitValue(line.First(x => Char.IsDigit(x)));
    var lastDigit = CharUnicodeInfo.GetDecimalDigitValue(line.Last(x => Char.IsDigit(x)));

    sum += firstDigit * 10 + lastDigit;
}

Console.WriteLine(sum);