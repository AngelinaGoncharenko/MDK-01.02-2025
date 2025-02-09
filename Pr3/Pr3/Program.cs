using ClassLibrary;
using System;

namespace Pr3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Число a:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Число b:");
            double b = Convert.ToDouble(Console.ReadLine());

            double sum = Class1.Add(a, b);
            Console.WriteLine($"Сумма: {sum}");

            double difference = Class1.Subtract(a, b);
            Console.WriteLine($"Разность: {difference}");

            double product = Class1.Multiply(a, b);
            Console.WriteLine($"Произведение: {product}");

            double quotient = Class1.Divide(a, b);
            Console.WriteLine($"Частное: {quotient}");

            double power = Class1.Power(a, b);
            Console.WriteLine($"a в степени b: {power}");

            double modulo = Class1.Modulo(a, b);
            Console.WriteLine($"Остаток от деления a на b: {modulo}");
        }
    }
}
