using System;

class Program
{
    static void Main()
    {
        try
        {
            // Ввод двузначного числа с клавиатуры
            Console.Write("Введите двузначное число: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number < 10 || number > 99)
            {
                throw new ArgumentOutOfRangeException("Число должно быть двузначным (от 10 до 99).");
            }

            // Разделение числа на цифры
            int firstDigit = number / 10; // Первая цифра (десятки)
            int secondDigit = number % 10; // Вторая цифра (единицы)

            // Вычисление произведения цифр
            int product = firstDigit * secondDigit;

            // Вывод результата
            Console.WriteLine($"Произведение цифр числа {number} равно {product}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка ввода! Убедитесь, что вводите число.");
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
