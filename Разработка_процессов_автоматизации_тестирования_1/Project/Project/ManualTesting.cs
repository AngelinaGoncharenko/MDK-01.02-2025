using System;

namespace Project
{
    public class ManualTesting
    {
        public static void TestAdd()
        {
            if (MathOperations.Add(2.0, 3.0) != 5.0)
            {
                Console.WriteLine("Результат операции неверный!");
            }
            else
            {
                Console.WriteLine("Результат операции верный");
            }
        }

        public static void TestSubtract()
        {
            if (MathOperations.Subtract(10.5, 1.2) != 9.3)
            {
                Console.WriteLine("Результат операции неверный!");
            }
            else
            {
                Console.WriteLine("Результат операции верный");
            }
        }

        public static void TestMultiply()
        {
            if (MathOperations.Add(2.2, 5.0) != 11.0)
            {
                Console.WriteLine("Результат операции неверный!");
            }
            else
            {
                Console.WriteLine("Результат операции верный");
            }
        }

        public static void TestDivide(double a = 5.0, double b = 2.0, double result = 2.5)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Деление на ноль невозможно!");
            }

            Console.Write("Введите значение для первого операнда, значение по умолчанию = 5.0: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение для второго операнда, значение по умолчанию = 2.0: ");
            b = Convert.ToDouble(Console.ReadLine());

            if (MathOperations.Divide(a, b) != result)
            {
                Console.WriteLine("Результат операции неверный!");
            }
            else
            {
                Console.WriteLine("Результат операции верный!");
            }
        }
    }
}
