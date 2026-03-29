int num1, num2;
string? operation;

Console.Write("Введите первое число: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите операцию (+, -, *, /): ");
operation = Console.ReadLine();

if (operation == "+")
{
    Console.WriteLine($"Результат: {Sum(num1, num2)}");
}
else if (operation == "-")
{
    Console.WriteLine($"Результат: {Subtract(num1, num2)}");
}
else if (operation == "*")
{
    Console.WriteLine($"Результат: {Multiply(num1, num2)}");
}
else if (operation == "/")
{
    Console.WriteLine($"Результат: {Divide(num1, num2)}");
}
else
{
    Console.WriteLine("Ошибка: неверная операция");
}

int Sum(int a, int b)
{
    return a + b;
}

int Subtract(int a, int b)
{
    return a - b;
}

int Multiply(int a, int b)
{
    return a * b;
}

double Divide(int a, int b)
{
    if (b != 0)
    {
        return (double)a / b;
    }
    else
    {
        Console.WriteLine("Ошибка: деление на ноль");
        return 0;
    }
}