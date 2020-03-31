using System;
using System.Diagnostics;

namespace HW06.Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3, 4, 5 };
            Int64[] arr2 = new Int64[100000000];
            var rand = new Random();
            long timer;
            int tempArr1;
            long tempArr2;

            Console.Write("Исходный массив ");
            foreach (var item in arr1)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.Write("Массив наоборт: ");
            for (int i = 0, j = arr1.Length - 1; i < j; i++, j--)
            {
                tempArr1 = arr1[i];
                arr1[i] = arr1[j];
                arr1[j] = tempArr1;
            }
            foreach (var item in arr1)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = rand.Next();
            }
            Stopwatch banch = new Stopwatch();
            banch.Start();
            for (long i = 0, j = arr2.Length - 1; i < j; i++, j--)
            {
                tempArr2 = arr2[i];
                arr2[i] = arr2[j];
                arr2[j] = tempArr2;
            }
            banch.Stop();
            timer = banch.ElapsedMilliseconds;
            Console.Write($"Мой реверс: {timer} мс.");
            Console.WriteLine();

            banch.Reset();
            banch.Start();
            Array.Reverse(arr2);
            banch.Stop();
            timer = banch.ElapsedMilliseconds;
            Console.Write($"Microsoft реверс: {timer} мс.");
            Console.WriteLine();
        }
    }
}
