Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (IsPrime(number))
{
    Console.WriteLine($"{number} - простое число");
}
else
{
    Console.WriteLine($"{number} - не простое число");
}

bool IsPrime(int n)
{
    if (n < 2) return false;
    for (int i = 2; i <= n / 2; i++)
    {
        if (n % i == 0) return false;
    }
    return true;
}