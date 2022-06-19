int number1 = Input ("Введите первое число: ");
int number2 = Input ("Введите второе число: ");
int Input (string output)
{
    Console.WriteLine (output);
    return Convert.ToInt32(Console.ReadLine ());
}

int modulo = number1 % number2;

if (modulo == 0)
{
    Console.WriteLine ("Кратно");
}
else
{
    Console.WriteLine ($"Некратно, остаток {modulo}");
}