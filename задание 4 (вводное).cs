using System;

class Program
{
    static void Main()
    {
        try
        {
            // Ввод высоты h
            Console.Write("Введите высоту (м): ");
            double h = Convert.ToDouble(Console.ReadLine());

            if (h < 0)
            {
                throw new ArgumentOutOfRangeException("Высота должна быть положительным числом.");
            }

            // Ускорение свободного падения
            double g = 9.81523;

            // Вычисление времени падения
            double t = Math.Sqrt((2 * h) / g);

            // Вывод результата
            Console.WriteLine($"Время падения: {t:F4} сек.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка ввода! Убедитесь, что вводите корректное число.");
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine($"Исключение: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }
    }
}
