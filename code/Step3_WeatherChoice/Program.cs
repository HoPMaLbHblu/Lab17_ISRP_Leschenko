
System.Console.WriteLine("Выбор одежды по погоде");
System.Console.Write("Введите текущую температуру (°C): ");
int temperature = Convert.ToInt32(Console.ReadLine());
if (temperature >= 20)
{
    System.Console.WriteLine("Наденьте лёгкую одежду");
}
else
{
    System.Console.WriteLine("Наденьте тёплую одежду");
}
System.Console.WriteLine("Хорошего дня!");