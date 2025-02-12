using System.IO;
using System;

namespace Practica_6
{
    class Program
    {
        private readonly static string _logFilePath = "debug_log.txt";

        private static void Main()
        {
            // 1. Ввод двух чисел с клавиатуры.
            Console.WriteLine("Введите первое число:");
            string input1 = Console.ReadLine();  // Точка останова 1
            int number1 = 0;
            if (!int.TryParse(input1, out number1))
            {
                Console.WriteLine("Ошибка: Некорректный ввод для первого числа.");
                return;
            }

            LogToFile($"Ввод первого числа: {number1}");

            Console.WriteLine("Введите второе число:");
            string input2 = Console.ReadLine();  // Точка останова 2
            int number2 = 0;
            if (!int.TryParse(input2, out number2))
            {
                Console.WriteLine("Ошибка: Некорректный ввод для второго числа.");
                return;
            }
            LogToFile($"Ввод второго числа: {number2}");


            // 2. Вычисление суммы и разности.
            int sum = number1 + number2;  // Точка останова 3
            LogToFile($"Сумма: {sum}");

            int difference = number1 - number2;  //Точка останова 4.  Условная точка останова: difference > 10
            LogToFile($"Разность: {difference}");

            // 3. Проверка, является ли сумма четным числом.
            bool isSumEven = sum % 2 == 0;  //Точка останова 5
            LogToFile($"Сумма четная: {isSumEven}");

            // 4.  Изменение значения переменной (Задание 2)
            if (!isSumEven)
            {
                Console.WriteLine("Сумма нечетная. Изменяем на четное число.");

                ++sum;
                isSumEven = sum % 2 == 0;
                LogToFile($"Сумма изменена на: {sum}. Сумма четная: {isSumEven}");

            }

            // 5. Вывод результатов.
            Console.WriteLine($"Сумма: {sum}");
            Console.WriteLine($"Разность: {difference}");
            Console.WriteLine($"Сумма четная: {isSumEven}");

            Console.ReadKey();
        }

        private static void LogToFile(string message)
        {
            try
            {
                using (StreamWriter writer = File.AppendText(_logFilePath))
                {
                    writer.WriteLine($"{DateTime.Now}: {message}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при записи в файл лога: {ex.Message}");
            }
        }
    }
}
