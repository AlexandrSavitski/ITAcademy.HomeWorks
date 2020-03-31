using System;

namespace HW06.Task1
{
    class Program
    {
        static int StrToInt()
        {
            int num;
            string str = Console.ReadLine();
            while (!Int32.TryParse(str, out num))
            {
                Console.Write("Введите целое число ");
                str = Console.ReadLine();
            }
            return num;
        }
        static void Main(string[] args)
        {
            var rand = new Random();
            int[] arr1 = new int[10];
            Console.Write("Массив 1: ");
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = rand.Next(100);
                Console.Write($"{arr1[i]} ");
            }

            Console.WriteLine();
            int[] arr2 = new int[arr1.Length];
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write($"Введите значение элемента {i+1} в массиве ");
                arr2[i] = StrToInt();
            }
            Console.Write("\nМассив 2: ");
            foreach (var item in arr2)
            {
                Console.Write(item + " ");
            }

            int[] arr3 = new int[arr1.Length];
            Console.Write("\nМассив 3: ");
            for (int i = 0; i < arr3.Length; i++)
            {
                arr3[i] = arr1[i] + arr2[i];
                Console.Write($"{arr3[i]} ");
            }
        }
    }
}
