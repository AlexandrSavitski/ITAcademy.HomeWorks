using System;

namespace Lect5.LetterA
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";

            for (int i = str.Length; i > 0; i--)
            {
                Console.Write(str[i-1]);
            }
        }
    }
}