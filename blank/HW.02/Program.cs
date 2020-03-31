using System;
using System.IO;

namespace HW._02
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Чтение файла по адресу D:\Home\image.txt
            //2. Считать файл
            //3. Освободить от неуправляемых ресурсов
            //4. Разбить массив на символы
            //5. Создать массив из бинарного кода
            //6. В цикле конвертировать в двоичный код
            //7. В цикле массив из битов записать в объект
            //8. Сохранить изображение по адресу D:\Home\image.png

            StreamReader textReader = new StreamReader(@"D:\Home\image.txt", true); 
            string textReaderResult = textReader.ReadToEnd(); 
            textReader.Dispose(); 
            string[] arrayOfTextResult = textReaderResult.Split(' '); 
            byte[] imageBytes = new byte[arrayOfTextResult.Length - 1]; 

            for (int i = 0; i < arrayOfTextResult.Length - 1; i++)
            {
                byte binary = Convert.ToByte(arrayOfTextResult[i], 2); 
                imageBytes[i] = binary; 
            }
            File.WriteAllBytes(@"D:\Home\image.png", imageBytes); 
        }
    }
}
