System.Console.WriteLine("Таблица умножения");

System.Console.Write("Введите число для таблицы умножения: ");
int number = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Таблица умножения для {number}:");

for (int i = 1; i <= 10; i++)
{
    int result = number * i;
    System.Console.WriteLine($"{number} * {i} = {result}");
}

System.Console.WriteLine("Конец программы");