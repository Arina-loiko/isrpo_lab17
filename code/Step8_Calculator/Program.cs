Console.WriteLine("Калькулятор");
Console.Write("Введите первое число: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите второе число: ");
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Сложение: {a} + {b} = {Sum(a, b)}");
Console.WriteLine($"Вычитание: {a} - {b} = {Subtract(a, b)}");
Console.WriteLine($"Умножение: {a} * {b} = {Multiply(a, b)}");
if (b != 0)
{
    Console.WriteLine($"Деление: {a} / {b} = {Divide(a, b)}");
}
else
{
    Console.WriteLine("Деление на ноль невозможно");
}

static double Sum(double a, double b)
{
    double result = a + b;
    return result;
}

static double Subtract(double a, double b)
{
    double result = a - b;
    return result;
}

static double Multiply(double a, double b)
{
    double result = a * b;
    return result;
}

static double Divide(double a, double b)
{
    double result = a / b;
    return result;
}
