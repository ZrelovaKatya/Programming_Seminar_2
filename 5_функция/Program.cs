int number = new Random ().Next(100,1000);
Console.WriteLine (number);

int firstDigit = number / 100;
int thirdDigit = number % 10;
int result = ConcatTwoDigit (firstDigit, thirdDigit);

Console.WriteLine (result);

int ConcatTwoDigit (int first, int second)
{
    return first * 10 + second;
}