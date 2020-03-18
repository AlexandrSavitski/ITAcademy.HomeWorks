using System;

namespace HW05.Task2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            char strChar = Convert.ToChar(str);
            bool wrong = true;

            switch (strChar)
            {
                case 'w':
                    str = " вперед";
                    break;
                case 'a':
                    str = " влево";
                    break;
                case 's':
                    str = " назад";
                    break;
                case 'd':
                    str = " вправо";
                    break;
                default:
                    str = "Вы ввели неверные данные";
                    wrong = false;
                    break;
            }
            
            if (wrong)
            {
                Console.WriteLine($"Вы переместились{str}");
            }
            else Console.WriteLine("Вы ввели неверные данные");
        }
    }
}
