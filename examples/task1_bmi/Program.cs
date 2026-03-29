
Console.Write("Введите ваш вес (кг): ");
double weight = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите ваш рост (м): ");
double height = Convert.ToDouble(Console.ReadLine());

double bmi = weight / (height * height);
string category = "";
string recommendation = "";

if (bmi < 18.5)
{
    category = "Недостаточный вес";
    recommendation = "Рекомендуется увеличить калорийность питания и обратиться к врачу.";
}
else if (bmi < 25)
{
    category = "Нормальный вес";
    recommendation = "Отлично! Поддерживайте здоровый образ жизни.";
}
else if (bmi < 30)
{
    category = "Избыточный вес";
    recommendation = "Рекомендуется увеличить физическую активность и пересмотреть питание.";
}
else
{
    category = "Ожирение";
    recommendation = "Рекомендуется обратиться к врачу для составления плана снижения веса.";
}

Console.WriteLine("\nРЕЗУЛЬТАТ:");
Console.WriteLine($"Ваш ИМТ: {bmi:F2}");
Console.WriteLine($"Категория: {category}");
Console.WriteLine($"Рекомендация: {recommendation}");