using System;

namespace HW05.Task2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string clearStr = "";
            string result = "";

            for (int i = 0; i < str.Length; i++)
            {
                switch (str[i])
                {
                    case 'w':
                        clearStr += "w";
                        break;
                    case 'a':
                        clearStr += "a";
                        break;
                    case 's':
                        clearStr += "s";
                        break;
                    case 'd':
                        clearStr += "d";
                        break;
                }
            }

            for (int i = 0; i < clearStr.Length; i++)
            {
                if (clearStr[i] == 'w') result += " вперед";
                if (clearStr[i] == 'a') result += " влево";
                if (clearStr[i] == 's') result += " назад";
                if (clearStr[i] == 'd') result += " вправо";
            }

            if (result == "") Console.WriteLine("Вы не сдвинулись с места");
            else Console.Write($"Вы переместились:{result}");
        }
    }
}
