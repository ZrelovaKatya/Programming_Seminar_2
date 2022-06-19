Console.WriteLine ("Введите первое число: ");
string input1 = Console.ReadLine ();
double number1 = Convert.ToInt32(input1);

Console.WriteLine ("Введите второе число: ");
string input2 = Console.ReadLine ();
double number2 = Convert.ToInt32(input2);

double diff = number1 / number2;
double remainder = diff % 1;

if (remainder == 0)
{
    Console.WriteLine ("Кратно");
}
else
{
    Console.WriteLine ($"Некратно, остаток {remainder}");
}

