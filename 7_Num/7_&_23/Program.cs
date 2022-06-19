Console.WriteLine ("Введите число: ");
string input = Console.ReadLine ();
double number = Convert.ToInt32(input);

double diff1 = number / 7;
double remainder1 = diff1 % 1;

double diff2 = number / 23;
double remainder2 = diff2 % 1;


if (remainder1 == 0 && remainder2 == 0)
{
    Console.WriteLine ("Да");
}

else
{
    Console.WriteLine ("Нет");
}
