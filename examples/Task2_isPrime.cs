Console.WriteLine("Проверка простого числа");
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (IsPrime(number))
{
    Console.WriteLine($"{number} - простое число");
}
else
{
    Console.WriteLine($"{number} - не является простым числом");
}

static bool IsPrime(int n)
{
    if (n <= 1)
    {
        return false;
    }
    for (int i = 2; i * i <= n; i++)
    {
        if (n % i == 0)
        {
            return false;
        }
    }
    return true;
}
