using System;

class Program
{
    static void Main()
    {
        try
        {
            // Заданное значение x
            double x = 5;

            // Вычисление функции y
            double y = (Math.Exp(2 * x) - Math.Exp(1 - x) + 2 * Math.Pow(Math.Sin(x), 2)) / (Math.PI * Math.Pow(x, 2));

            // Вывод результата
            Console.WriteLine($"Значение функции y при x = {x}: {y:F6}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }
    }
}
