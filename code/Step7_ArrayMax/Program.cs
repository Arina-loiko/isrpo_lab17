int[] grades = { 5, 4, 5, 3, 4 };
int max = grades[0];
for (int i = 1; i < grades.Length; i++)
{
    if (grades[i] > max)
    {
        max = grades[i];
    }
}
Console.WriteLine("Поиск максимальной оценки");
Console.Write("Массив: ");
Console.WriteLine(string.Join(", ", grades));
Console.WriteLine($"Максимальная оценка: {max}");
Console.WriteLine("Конец программы");
