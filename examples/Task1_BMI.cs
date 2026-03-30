Console.WriteLine("Калькулятор ИМТ");
Console.Write("Введите вес (кг): ");
double weight = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите рост (м): ");
double height = Convert.ToDouble(Console.ReadLine());
double bmi = weight / (height * height);
string category;
string recommendation;
if (bmi < 18.5)
{
    category = "Недостаточный вес";
    recommendation = "Рекомендуется увеличить калорийность питания";
}
else if (bmi < 25)
{
    category = "Нормальный вес";
    recommendation = "Отличный результат, продолжайте в том же духе";
}
else if (bmi < 30)
{
    category = "Избыточный вес";
    recommendation = "Рекомендуется больше двигаться и следить за питанием";
}
else
{
    category = "Ожирение";
    recommendation = "Рекомендуется обратиться к врачу";
}
Console.WriteLine($"\nВаш ИМТ: {bmi:F2}");
Console.WriteLine($"Категория: {category}");
Console.WriteLine($"Рекомендация: {recommendation}");
