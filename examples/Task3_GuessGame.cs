Random random = new Random();
bool playAgain = true;
while (playAgain)
{
    int secret = random.Next(1, 101);
    int attempts = 0;
    bool guessed = false;
    Console.WriteLine("\nИгра: угадай число от 1 до 100");
    while (!guessed)
    {
        Console.Write("Ваша попытка: ");
        string input = Console.ReadLine();
        if (!int.TryParse(input, out int guess))
        {
            Console.WriteLine("Введите корректное число");
            continue;
        }
        attempts++;
        if (guess == secret)
        {
            guessed = true;
            Console.WriteLine($"Правильно! Вы угадали за {attempts} попыток");
        }
        else if (guess < secret)
        {
            Console.WriteLine("Больше!");
        }
        else
        {
            Console.WriteLine("Меньше!");
        }
    }
    Console.Write("Играть снова? (да/нет): ");
    string answer = Console.ReadLine();
    playAgain = answer == "да";
}
Console.WriteLine("Спасибо за игру!");
