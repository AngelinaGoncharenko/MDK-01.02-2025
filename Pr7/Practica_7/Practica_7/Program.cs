using System;

namespace Practica_7
{
    class Program
    {
        private static void Main()
        {
            Calculator calculator = new();
            EventLogger eventLogger = new();

            calculator.OnCalculationPerformed += eventLogger.CalculationPerformedLog;
            calculator.OnCalculationPerformed += EventLogger.LogToConsole;

            try
            {
                Console.WriteLine("Введите первое число:");
                string input1 = Console.ReadLine();
                int number1 = int.Parse(input1);

                Console.WriteLine("Введите второе число:");
                string input2 = Console.ReadLine();
                int number2 = int.Parse(input2);

                Console.WriteLine("Выберите операцию (+, -, *, /):");
                string operation = Console.ReadLine();

                double result = 0;

                switch (operation)
                {
                    case "+":
                        result = calculator.Add(number1, number2);
                        eventLogger.Log($"Вызвана операция сложения: {number1} + {number2} = {result}");
                        break;
                    case "-":
                        result = calculator.Subtract(number1, number2);
                        eventLogger.Log($"Вызвана операция вычитания: {number1} - {number2} = {result}");
                        break;
                    case "*":
                        result = calculator.Multiply(number1, number2);
                        eventLogger.Log($"Вызвана операция умножения: {number1} * {number2} = {result}");
                        break;
                    case "/":
                        result = calculator.Divide(number1, number2);
                        eventLogger.Log($"Вызвана операция деления: {number1} / {number2} = {result}");
                        break;
                    default:
                        Console.WriteLine("Некорректная операция.");
                        eventLogger.Log("Попытка вызова некорректной операции.");
                        return;
                }

                Console.WriteLine($"Результат: {result}");
            }
            catch (FormatException exception)
            {
                // Точка останова 6: В блоке catch для FormatException
                Console.WriteLine($"Ошибка: Некорректный формат ввода. {exception.Message}");
                eventLogger.Log($"Ошибка формата ввода: {exception.Message}");
            }
            catch (DivideByZeroException exception)
            {
                // Точка останова 7: В блоке catch для DivideByZeroException
                Console.WriteLine($"Ошибка: Деление на ноль. {exception.Message}");
                eventLogger.Log($"Ошибка деления на ноль: {exception.Message}");
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
