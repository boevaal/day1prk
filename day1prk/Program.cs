using System;
using System.Collections.Generic;
using System.Linq;

namespace day1prk
{
    class Program
    {
        static void Main()
        {
            while (true)
            {                
                Console.Clear();

                
                Console.WriteLine("Выберите номер задания:");
                Console.WriteLine("1. Разработайте программу, которая принимает четыре числа и находит среднее значение между ними.");
                Console.WriteLine("2. Разработайте программу-калькулятор, в которой можно выбрать действие для двух вводимых пользователем чисел.");
                Console.WriteLine("3. Разработайте программу для конвертации температуры.");
                Console.WriteLine("4. Разработайте программу, которая позволяет определить имя файла (с расширением) по введенному пути.");
                Console.WriteLine("5. Разработайте программу для нахождения самого длинного слова в предложении.");
                Console.WriteLine("6. Разработайте программу, которая может перемножить два массива значений.");
                Console.WriteLine("7. Разработайте программу, которая может найти максимальное и минимальное число из пяти введенных.");
                Console.WriteLine("8. Разработайте программу, которая выводит ‘пирамиду’ из чисел из количества уровней, введенных пользователем.");
                Console.WriteLine("9. Напечатать полную таблицу умножения.");
                Console.WriteLine("10.Вариант 1: выведите элементы, которые меньше 10, между 5 и 9, а также четные числа.");

                string taskChoice = Console.ReadLine();

                switch (taskChoice)
                {
                    case "1":
                        Task1();
                        break;
                    case "2":
                        Task2();
                        break;
                    case "3":
                        Task3();
                        break;
                    case "4":
                        Task4();
                        break;
                    case "5":
                        Task5();
                        break;
                    case "6":
                        Task6();
                        break;
                    case "7":
                        Task7();
                        break;
                    case "8":
                        Task8();
                        break;
                    case "9":
                        Task9();
                        break;
                    case "10":
                        Task10();
                        break;
                    default:
                        Console.WriteLine("Неверный выбор. Попробуйте еще раз.");
                        break;
                }

                Console.WriteLine("Задание завершено, нажмите на любую клавишу, чтобы вернуться к списку задач.");
                Console.ReadKey();
            }
        }

        // Задание 1: Среднее значение из 4 чисел
        static void Task1()
        {
            Console.Clear();
            Console.WriteLine("Задание 1. Разработайте программу, которая принимает четыре числа и находит среднее значение между ними.");

            Console.WriteLine("Введите первое число:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите третье число:");
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите четвертое число:");
            int num4 = int.Parse(Console.ReadLine());

            int average = (num1 + num2 + num3 + num4) / 4;

            Console.WriteLine($"Среднее значение: {average}");
        }

        // Задание 2: Калькулятор
        static void Task2()
        {
            Console.Clear();
            Console.WriteLine("Задание 2. Разработайте программу-калькулятор для двух чисел.");

            Console.WriteLine("Введите первое число:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Выберите операцию:");
            Console.WriteLine("1. Сложение");
            Console.WriteLine("2. Вычитание");
            Console.WriteLine("3. Умножение");
            Console.WriteLine("4. Деление");
            Console.WriteLine("5. Нахождение остатка");
            int choice = int.Parse(Console.ReadLine());
            int result = 0;

            switch (choice)
            {
                case 1:
                    result = num1 + num2;
                    Console.WriteLine($"Результат: {num1} + {num2} = {result}");
                    break;
                case 2:
                    result = num1 - num2;
                    Console.WriteLine($"Результат: {num1} - {num2} = {result}");
                    break;
                case 3:
                    result = num1 * num2;
                    Console.WriteLine($"Результат: {num1} * {num2} = {result}");
                    break;
                case 4:
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        Console.WriteLine($"Результат: {num1} / {num2} = {result}");
                    }
                    else
                    {
                        Console.WriteLine("Ошибка! Деление на ноль невозможно.");
                    }
                    break;
                case 5:
                    result = num1 % num2;
                    Console.WriteLine($"Результат: {num1} % {num2} = {result}");
                    break;
                default:
                    Console.WriteLine("Неверный выбор операции.");
                    break;
            }
        }

        // Задание 3: Конвертация температуры
        static void Task3()
        {
            Console.Clear();
            Console.WriteLine("Задание 3. Разработайте программу для конвертации температуры.");

            Console.WriteLine("Выберите шкалу исходной температуры:");
            Console.WriteLine("1. Цельсий");
            Console.WriteLine("2. Кельвин");
            Console.WriteLine("3. Фаренгейт");

            int fromScale = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите температуру:");
            double temp = double.Parse(Console.ReadLine());

            Console.WriteLine("Выберите шкалу для конвертации:");
            Console.WriteLine("1. Цельсий");
            Console.WriteLine("2. Кельвин");
            Console.WriteLine("3. Фаренгейт");

            int toScale = int.Parse(Console.ReadLine());
            double convertedTemp = 0;

            switch (fromScale)
            {// Цельсий
                case 1: 
                    if (toScale == 1)
                        convertedTemp = temp;
                    else if (toScale == 2)
                        convertedTemp = temp + 273.15;
                    else if (toScale == 3)
                        convertedTemp = temp * 9 / 5 + 32;
                    break;
                // Кельвин
                case 2:
                    
                    if (toScale == 1)
                        convertedTemp = temp - 273.15;
                    else if (toScale == 2)
                        convertedTemp = temp;
                    else if (toScale == 3)
                        convertedTemp = (temp - 273.15) * 9 / 5 + 32;
                    break;
                // Фаренгейт
                case 3:
                    
                    if (toScale == 1)
                        convertedTemp = (temp - 32) * 5 / 9;
                    else if (toScale == 2)
                        convertedTemp = (temp - 32) * 5 / 9 + 273.15;
                    else if (toScale == 3)
                        convertedTemp = temp;
                    break;
            }

            Console.WriteLine($"Конвертированная температура: {convertedTemp}");
        }

        // Задание 4: Определение имени файла по пути
        static void Task4()
        {
            Console.Clear();
            Console.WriteLine("Задание 4. Разработайте программу, которая позволяет определить имя файла по введенному пути.");

            Console.WriteLine("Введите путь до файла:");
            string filePath = Console.ReadLine();

            string fileName = System.IO.Path.GetFileName(filePath);
            Console.WriteLine($"Имя файла: {fileName}");
        }

        // Задание 5: Самое длинное слово
        static void Task5()
        {
            Console.Clear();
            Console.WriteLine("Задание 5. Разработайте программу для нахождения самого длинного слова в предложении.");

            Console.WriteLine("Введите предложение:");
            string sentence = Console.ReadLine();

            string[] words = sentence.Split(' ');
            string longestWord = "";
            foreach (string word in words)
            {
                if (word.Length > longestWord.Length)
                {
                    longestWord = word;
                }
            }

            Console.WriteLine($"Самое длинное слово: {longestWord}");
        }

        // Задание 6: Перемножение массивов
        static void Task6()
        {
            Console.Clear();
            Console.WriteLine("Задание 6. Разработайте программу, которая может перемножить два массива значений.");

            Console.WriteLine("Введите значения для первого массива через пробел:");
            string[] array1 = Console.ReadLine().Split(' ');

            Console.WriteLine("Введите значения для второго массива через пробел:");
            string[] array2 = Console.ReadLine().Split(' ');

            int[] result = new int[array1.Length];

            for (int i = 0; i < array1.Length; i++)
            {
                result[i] = int.Parse(array1[i]) * int.Parse(array2[i]);
            }

            Console.WriteLine("Результат умножения массивов:");
            foreach (var res in result)
            {
                Console.Write(res + " ");
            }
            Console.WriteLine();
        }

        // Задание 7: Нахождение максимального и минимального числа
        static void Task7()
        {
            Console.Clear();
            Console.WriteLine("Задание 7. Разработайте программу, которая может найти максимальное и минимальное число из пяти введенных.");

            Console.WriteLine("Введите пять чисел:");

           
            int[] numbers = new int[5];
            for (int i = 0; i < 5; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            
            int maxNumber = numbers[0];
            int minNumber = numbers[0];

            for (int i = 1; i < 5; i++)
            {
                if (numbers[i] > maxNumber)
                {
                    maxNumber = numbers[i];
                }
                if (numbers[i] < minNumber)
                {
                    minNumber = numbers[i];
                }
            }

            // Вывод результата
            Console.WriteLine($"Максимальное число: {maxNumber}");
            Console.WriteLine($"Минимальное число: {minNumber}");
        }

        // Задание 8: Пирамида чисел
        static void Task8()
        {
            Console.Clear();
            Console.WriteLine("Задание 8. Разработайте программу, которая выводит ‘пирамиду’ из чисел из количества уровней, введенных пользователем.");

            Console.WriteLine("Введите количество ступеней:");
            int steps = int.Parse(Console.ReadLine());

            
            for (int i = 1; i <= steps; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }

        // Задание 9: Полная таблица умножения
        static void Task9()
        {
            Console.Clear();
            Console.WriteLine("Задание 9. Полная таблица умножения.");

            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    Console.Write($"{i} х {j} = {i * j}\t");
                }
                Console.WriteLine();
            }
        }

        // Задание 10: Вариант 1
        static void Task10()
        {
            Console.Clear();
            Console.WriteLine("Задание 10. Ваоиант 1.");

            List<int> a = new List<int> { 0, 0, 3, 4, 5, 5, 6, 10, 12, 13, 15, 22, 33, 35, 37, 40, 56, 88, 90 };

            Console.WriteLine("Элементы, которые меньше 10:");
            foreach (var item in a)
            {
                if (item < 10)
                {
                    Console.WriteLine(item);
                }
            }

            
            Console.WriteLine("\nЭлементы, которые больше 5 и меньше 9:");
            foreach (var item in a)
            {
                if (item > 5 && item < 9)
                {
                    Console.WriteLine(item);
                }
            }

           
            Console.WriteLine("\nЭлементы, которые делятся на 2 (четные числа):");
            foreach (var item in a)
            {
                if (item % 2 == 0)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
