using System;

class Program
{
    static void Main()
    {
        try
        {
            // Ввод значения угла a (в радианах)
            Console.Write("Введите значение угла a (в радианах): ");
            double a = Convert.ToDouble(Console.ReadLine());

            // Вычисление по формуле Z2 = (1 - Math.Tan(a)) / (1 + Math.Tan(a))
            double Z2 = (1 - Math.Tan(a)) / (1 + Math.Tan(a));

            // Вывод результатов
            Console.WriteLine($"Z2 = {Z2:F6}");
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
