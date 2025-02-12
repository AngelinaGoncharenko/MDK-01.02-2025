using System.Collections.Generic;
using System;

namespace Practica_5
{
    class Program
    {
        private static void Main()
        {
            List<int> numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
            int divisor = 2;

            List<string> strings = ["apple", "banana", "kiwi", "strawberry", "orange"];

            string testPalindrome = "Racecar";

            List<int> filteredNumbers = FilterNumbers(numbers, divisor);
            Console.WriteLine($"Filtered numbers: {string.Join(", ", filteredNumbers)}");

            string longestString = FindLongestString(strings);
            Console.WriteLine($"Longest string: {longestString}");

            string upperCaseString = testPalindrome.ToUpper();
            bool isPalindrome = IsPalindrome(upperCaseString);
            Console.WriteLine($"Is '{testPalindrome}' a palindrome? {isPalindrome}");


            Console.ReadKey();
        }

        public static List<int> FilterNumbers(List<int> numbers, int divisor)
        {
            //Точка останова 1: Проверить входные данные (numbers, divisor)
            if (numbers == null)
            {
                Console.WriteLine("Numbers list is null. Returning an empty list.");
                return [];
            }

            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                //Точка останова 2:  Проверить текущее число numbers[i] и divisor
                if (numbers[i] % divisor == 0)
                {
                    //Точка останова 3: Перед удалением элемента
                    numbers.RemoveAt(i);
                }
            }
            return numbers;
        }

        public static string FindLongestString(List<string> strings)
        {
            //Точка останова 4: Проверить входные данные (strings)
            if (strings == null || strings.Count == 0)
            {
                Console.WriteLine("String list is null or empty. Returning an empty string.");
                return string.Empty;
            }

            string longestString = string.Empty;
            //Точка останова 5: Перед началом цикла
            foreach (string str in strings)
            {
                //Точка останова 6: Проверить текущую строку str и longestString
                if (str != null && str.Length > longestString.Length)
                {
                    //Точка останова 7: Внутри условия, когда найдена более длинная строка
                    longestString = str;
                }
            }
            return longestString;
        }

        public static bool IsPalindrome(string str)
        {
            //Точка останова 8: Проверить входную строку str
            if (string.IsNullOrEmpty(str))
            {
                Console.WriteLine("String is null or empty.  Returning false.");
                return false;
            }

            for (int i = 0; i < str.Length / 2; i++)
            {
                //Точка останова 9:  Проверить символы strUpper[i] и strUpper[strUpper.Length - i - 1]
                if (str[i] != str[str.Length - i - 1])
                {
                    //Точка останова 10:  Если символы не совпадают
                    return false;
                }
            }

            return true;
        }
    }
}
