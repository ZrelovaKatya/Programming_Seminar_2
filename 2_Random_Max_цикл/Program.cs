int number = new Random ().Next(10,100); // любое число от 10 до 99 включительно
int max = int.MinValue; //можно поставить ноль, но для случаев c минусом MinValue

Console.WriteLine (number); //для вывода числа любого

while (number > 0)
{
    int lastDigit = number % 10;
    if (lastDigit > max)
    {
        max = lastDigit;
    }
    number = number/10;
}

Console.WriteLine (max);