int number = Convert.ToInt32(Console.ReadLine());
int num1 = 7;
int num2 = 23;

if (CheckMultiply (number, num1) && CheckMultiply (number, num2))
{
    Console.WriteLine ("Кратно");
}

bool CheckMultiply (int a, int b)
{
    return a % b == 0;
}