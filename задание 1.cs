using System;

class Program
{
    static void Main()
    {
        try
        {
            // Запрос трех целых чисел у пользователя
            Console.Write("Введите первое число: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите третье число: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            // Вычисление суммы
            int sum = num1 + num2 + num3;

            // Вывод суммы в прямом порядке
            Console.WriteLine($"\nСумма чисел в прямом порядке: {num1} + {num2} + {num3} = {sum}");

            // Вывод суммы в обратном порядке
            Console.WriteLine($"Сумма чисел в обратном порядке: {num3} + {num2} + {num1} = {sum}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка ввода! Убедитесь, что вводите целые числа.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }
    }
}
