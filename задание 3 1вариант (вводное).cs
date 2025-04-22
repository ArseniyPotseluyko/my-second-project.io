using System;

class Program
{
    static void Main()
    {
        try
        {
            // Ввод угла a с клавиатуры
            Console.Write("Введите значение угла a (в радианах): ");
            double a = Convert.ToDouble(Console.ReadLine());

            // Вычисление по первой формуле Z1 = (1 - 2 * Math.Pow(Math.Sin(a), 2)) / (1 + Math.Sin(2 * a))
            double Z1 = (1 - 2 * Math.Pow(Math.Sin(a), 2)) / (1 + Math.Sin(2 * a));

            // Вычисление по второй (эквивалентной) формуле Z2 = cos(2a) / (1 + sin(2a))
            double Z2 = Math.Cos(2 * a) / (1 + Math.Sin(2 * a));

            // Вывод результатов
            Console.WriteLine($"Z1 = {Z1:F6}");
            Console.WriteLine($"Z2 = {Z2:F6}");

            // Проверка совпадения значений
            Console.WriteLine(Z1 == Z2 ? "Результаты совпадают!" : "Результаты различаются.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка ввода! Убедитесь, что вводите корректное число.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }
    }
}
