using System;

class Program
{
    static void Main()
    {
        try
        {
            // Ввод данных с клавиатуры
            Console.Write("Введите радиус основания (см): ");
            double radius = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите высоту цилиндра (см): ");
            double height = Convert.ToDouble(Console.ReadLine());

            if (radius <= 0 || height <= 0)
            {
                throw new ArgumentOutOfRangeException("Радиус и высота должны быть положительными числами.");
            }

            // Вычисление объема цилиндра
            double volume = Math.PI * Math.Pow(radius, 2) * height;

            // Вывод результата
            Console.WriteLine($"Объем цилиндра: {volume:F2} куб. см.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка ввода! Убедитесь, что вы вводите корректные числа.");
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
