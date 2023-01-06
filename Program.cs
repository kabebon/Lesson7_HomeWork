using System;


namespace Lesson7
{
    class Switch
    {
        public static void Main()
        {
            while (true)
            {
                Console.WriteLine("1.Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.");
                Console.WriteLine("2.Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет");
                Console.WriteLine("3.Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце");

                Console.Write("Выбери номер задания:");
                if (TryGetUserInput(out int value))
                {
                    switch (value)
                    {
                        case 1: Task47.Task47Main(); break;
                        case 2: Task50.Task50Main(); break;
                        case 3: Task52.Task52Main(); break;
                        default: Console.WriteLine("Извини, такой задачи нет :(. Попробуй еще раз!"); break;
                    }
                }
            }

        }

        private static bool IsString(string input)
        {
            return !int.TryParse(input, out _);
        }

        private static bool TryGetUserInput(out int value)
        {
            string input = Console.ReadLine();
            if (IsString(input))
            {
                value = 0;
                Console.WriteLine("Введи число, а не букву!");
                return false;
            }

            else
            {
                value = int.Parse(input);
                return true;
            }
        }
    }
    //Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
    class Task47
    {
        public static void Task47Main()
        {
            Console.WriteLine("Введите размер M");
            int length = ReadInt();
            Console.WriteLine("Введите размер N");
            int secondLength = ReadInt();
            double[,] array = GetArray(length, secondLength);
            PrintArray(array);
            Console.ReadLine();
        }

        private static int ReadInt()
        {
            return int.Parse(Console.ReadLine());
        }

        private static double[,] GetArray(int length, int secondLength)
        {
            double[,] array = new double[length, secondLength];
            Random random = new Random();
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < secondLength; j++)
                {
                    array[i, j] = 1 + random.NextDouble() * 99;
                }
            }
            return array;
        }

        private static void PrintArray(double[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }


    //Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет
    class Task50
    {
        public static void Task50Main()
        {
            Console.WriteLine("Введите длину массива:");
            int length = ReadInt();
            Console.WriteLine("Введите ширину массива:");
            int secondLength = ReadInt();
            int[,] array = GetArray(length, secondLength);
            PrintArray(array);
            Console.WriteLine("Введите позицию элемента по длине:");
            int i = ReadInt();
            Console.WriteLine("Введите позицию элемента по ширине:");
            int j = ReadInt();

            if (i <= length && j <= secondLength) Console.WriteLine($"Запрошенный элемент: {array[i - 1, j - 1]}");
            else Console.WriteLine("Такого числа в массиве нет");
        }

        private static int ReadInt()
        {
            return int.Parse(Console.ReadLine());
        }

        private static int[,] GetArray(int length, int secondLength)
        {
            int[,] array = new int[length, secondLength];
            Random random = new Random();
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < secondLength; j++)
                {
                    array[i, j] = random.Next(1000);
                }
            }
            return array;
        }

        private static void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }


    //Задача 52.Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

    class Task52
    {
        public static void Task52Main()
        {
            Console.WriteLine("Введи высоту:");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введи ширину:");
            int columns = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[rows, columns];
            int[] sum = new int[columns];
            Random ran = new Random();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    arr[i, j] = ran.Next(0, 100);

                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    sum[i] += arr[j, i];
                }
            }

            for (int i = 0; i < columns; i++)
            {
                Console.Write((sum[i] / rows) + " ");
            }
            Console.ReadLine();
        }


    }
}
