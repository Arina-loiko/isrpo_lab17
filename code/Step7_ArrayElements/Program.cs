int[] grades = { 5, 4, 5, 3, 4 };
Console.WriteLine("Оценки студента:");
for (int i = 0; i < grades.Length; i++)
{
    Console.WriteLine($"Оценка {i + 1}: {grades[i]}");
}
Console.WriteLine("Конец программы");
