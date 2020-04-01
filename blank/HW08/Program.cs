using System;
using System.Text;

namespace HW08
{
    class Program
    {
        static void Main(string[] args)
        {
            string str2;
            string str3 = "1a!2.3!!.. 4.!.?6 7! ..?";
            Task1 task1 = new Task1();
            Task2 task2 = new Task2();
            Task3 task3 = new Task3();

            Console.WriteLine("Введите стих, разделяя строки \";\"");
            task1.Poem(Console.ReadLine());
            Console.WriteLine("Введите текст с очень длинным словом (самое длинное слово будет удалено)");
            str2 = Console.ReadLine();
            task2.DeleteLongWord(str2);
            Console.WriteLine("Поменять местами длинное и короткое слово");
            task2.ReplaceWord(str2);
            task2.CountLetterSymbol(str2);
            Console.WriteLine("Сортировка по убыванию");
            task2.Sort(str2);
            task3.ActionWithString(str3);
        }
    }
}
