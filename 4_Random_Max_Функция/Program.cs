int number = GetRundomNumber ();
Console.WriteLine (number);
int maxDigit = FindMaxDigit (number);
Console.WriteLine (maxDigit);


int GetRundomNumber ()
{
    return new Random ().Next(10,100);
}

int FindMaxDigit (int number)
{
    int max = 0;
    while (number > 0)
    {
        int lastDigit = number % 10;
        if (lastDigit > max)
        {
            max = lastDigit;
        }
        number = number / 10;
    }
    return max;
}