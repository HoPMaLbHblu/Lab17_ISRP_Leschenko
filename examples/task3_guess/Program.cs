Random random = new Random();
int totalGames = 0;
int totalAttempts = 0;
bool playAgain = true;

Console.WriteLine("==== ИГРА 'УГАДАЙ ЧИСЛО' ====");
Console.WriteLine("Компьютер загадал число от 1 до 100\n");

while (playAgain)
{
    int secretNumber = random.Next(1, 101);
    int attempts = 0;
    bool guessed = false;

    Console.WriteLine("Новая игра! Я загадал число от 1 до 100.");

    while (!guessed)
    {
        Console.Write("Ваша попытка: ");
        string input = Console.ReadLine();

        if (!int.TryParse(input, out int guess))
        {
            Console.WriteLine("Ошибка: введите целое число!");
            continue;
        }

        attempts++;

        if (guess < 1 || guess > 100)
        {
            Console.WriteLine("Число должно быть от 1 до 100!");
            continue;
        }

        if (guess == secretNumber)
        {
            Console.WriteLine($"\nПоздравляю! Вы угадали число {secretNumber} за {attempts} попыток!");
            guessed = true;
        }
        else if (guess < secretNumber)
        {
            Console.WriteLine("Больше!");
        }
        else
        {
            Console.WriteLine("Меньше!");
        }
    }

    totalGames++;
    totalAttempts += attempts;

    Console.WriteLine($"\nСтатистика: сыграно игр - {totalGames}, всего попыток - {totalAttempts}, среднее попыток - {(double)totalAttempts / totalGames:F2}");

    Console.Write("\nХотите сыграть ещё? (да/нет): ");
    string answer = Console.ReadLine();
    playAgain = (answer.ToLower() == "да" || answer.ToLower() == "yes" || answer.ToLower() == "y");

    if (playAgain)
    {
        Console.WriteLine("\n==== НОВАЯ ИГРА ====\n");
    }
}

Console.WriteLine("\nСпасибо за игру! До свидания!");