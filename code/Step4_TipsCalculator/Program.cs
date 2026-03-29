
System.Console.WriteLine("Калькулятор чаевых");
System.Console.Write("Введите сумму счёта (руб): ");
double bill = System.Convert.ToDouble(System.Console.ReadLine());
System.Console.Write("Введите процент чаевых (например, 10): ");
double tipPercent = System.Convert.ToDouble(System.Console.ReadLine());

double tipAmount = bill * (tipPercent / 100);
double totalAmount = bill + tipAmount;

System.Console.WriteLine("\nРезультат:");
System.Console.WriteLine($"Сумма счёта: {bill} руб");
System.Console.WriteLine($"Чаевые: {tipPercent}%: {tipAmount} руб");
System.Console.WriteLine($"Итого к оплате: {totalAmount} руб");

System.Console.WriteLine("Спасибо за использование калькулятора!");