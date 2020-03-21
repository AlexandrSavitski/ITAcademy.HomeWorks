using System;

namespace HW06.Task2
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
            int[] arr = new int[10];
            int lastNum;
            int numPos;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                Console.Write($"Введите значение элемента {i + 1} в массиве ");
                arr[i] = StrToInt();
            }
            Console.Write("Введите последнее число массива ");
            lastNum = StrToInt();
            Console.Write("Введите позицию в массиве ");
            numPos = StrToInt();
            while (numPos < 1 || numPos > 10)
            {
                Console.WriteLine("Вы превысили размерность массива. Пожалуйста, введите целое число от 1 до 10");
                numPos = StrToInt();
            }
            Console.Write("Не полный массив: ");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            for (int i = arr.Length - 1; i > numPos - 1; i--)
            {
                arr[i] = arr[i - 1];
            }
            arr[numPos - 1] = lastNum;
            Console.Write("Полный массив: ");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
        }
    }
}
