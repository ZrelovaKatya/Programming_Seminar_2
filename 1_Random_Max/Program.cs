int number = new Random ().Next(10,100); // любое число от 10 до 99 включительно
int max = int.MinValue; //можно поставить ноль, но для случаев c минусом MinValue

Console.WriteLine (number); //для вывода числа любого

int firstDigit = number / 10;
int secondDigit = number % 10; //остаток от деления на 10

if (firstDigit > max)
{
    max = firstDigit;
}

if (secondDigit > max)
{
    max = secondDigit;
}

Console.WriteLine (max);