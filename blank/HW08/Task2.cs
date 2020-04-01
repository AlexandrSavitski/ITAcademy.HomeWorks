using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace HW08
{
    class Task2
    {
        internal void DeleteLongWord(string str)
        {
            string[] strArr = StringToArray(str);
            str = str.Remove(0, str.Length);
            int maxlen = 0, index = 0;

            for (int i = 0; i < strArr.Length; i++)
            {
                if (strArr[i].Length > maxlen)
                {
                    maxlen = strArr[i].Length;
                    index = i;
                }
            }
            for (int i = 0; i < strArr.Length; i++)
            {
                if (i != index) str += $"{strArr[i]} ";
            }
            Console.WriteLine(str = str.Trim());
        }

        internal void ReplaceWord(string str)
        {
            int tempMax = 0;
            int tempMin = 0;
            string temp;
            string[] arr = StringToArray(str);

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length > arr[tempMax].Length) tempMax = i;
                if (arr[i].Length < arr[tempMin].Length) tempMin = i;
            }
            temp = arr[tempMax];
            arr[tempMax] = arr[tempMin];
            arr[tempMin] = temp;

            str = str.Remove(0, str.Length);
            for (int i = 0; i < arr.Length; i++)
            {
                str += $"{arr[i]} ";
            }
            Console.WriteLine(str = str.Trim());
        }

        internal void CountLetterSymbol(string str)
        {
            int countSymbol = 0;
            int countLetter = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsLetter(str[i])) countLetter++;
                if (!Char.IsLetter(str[i]) && !str[i].Equals(' ')) countSymbol++;
            }

            Console.WriteLine($"Букв: {countLetter}");
            Console.WriteLine($"Символов: {countSymbol}");
        }

        internal void Sort(string str)
        {
            string[] arr = StringToArray(str);
            string temp;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i].Length < arr[j].Length)
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            foreach (var item in arr)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }

        string[] StringToArray(string str)
        {
            string[] strArr = str.Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return strArr;
        }
    }
}
