using System;

namespace Practica_7
{
    public class Calculator
    {
        public delegate void CalculationPerformedHandler(string details);
        public event CalculationPerformedHandler? OnCalculationPerformed;

        public int Add(int a, int b)
        {
            // Точка останова 1: На первой строке метода Add
            int result = a + b;
            OnCalculationPerformed?.Invoke($"Сложение: {a} + {b} = {result}");
            return result;
        }

        public int Subtract(int a, int b)
        {
            // Точка останова 2: На первой строке метода Subtract
            int result = a - b;
            OnCalculationPerformed?.Invoke($"Вычитание: {a} - {b} = {result}");
            return result;
        }

        public int Multiply(int a, int b)
        {
            // Точка останова 3: На первой строке метода Multiply
            int result = a * b;
            OnCalculationPerformed?.Invoke($"Умножение: {a} * {b} = {result}");
            return result;
        }

        public double Divide(double a, double b)
        {
            // Точка останова 4: На первой строке метода Divide
            if (b == 0)
            {
                throw new DivideByZeroException("Деление на ноль недопустимо.");
            }
            double result = (double)a / b;
            OnCalculationPerformed?.Invoke($"Деление: {a} / {b} = {result}");
            return result;
        }
    }
}
