using System;

namespace HW03.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            short x = 123;
            int y = 231;
            float z = 321.1f;
            Console.WriteLine("Переменные: " + "x=" + x + ", y=" + y + ", z=" + z);

            // явное преобразование
            byte convertX = (byte)x;
            short convertY = (short)y;
            int convertZ = (int)z;
            Console.WriteLine("Явное преобразование (Метод 1): xByte=" + convertX + ", yShort=" + convertY + ", zInt=" + convertZ);

            byte convertToX = Convert.ToByte(x);
            short convertToY = Convert.ToInt16(y);
            int convertToZ = Convert.ToInt32(z);
            Console.WriteLine("Явное преобразование (Метод 2): xByte=" + convertToX + ", yShort=" + convertToY + ", zInt=" + convertToZ);

            // неявное преобразование
            int xx = x;
            float yy = y;
            double zz = z;
            Console.WriteLine("Неявное преобразование: xInt =" + xx + ", yFloat=" + yy + ", zDouble=" + zz);

            // упаковка (boxing)
            object X = x;
            object Y = y;
            object Z = z;
            Console.WriteLine("Упаковка: X=" + X + ", Y=" + Y + ", Z=" + Z);

            // распаковка (unboxing)
            x = (short)X;
            y = (int)Y;
            z = (float)Z;
            Console.WriteLine("Распаковка: x=" + X + ", y=" + Y + ", z=" + Z);

            // упаковка-распаковка
            int var1 = 111;
            bool var2 = true;
            char var3 = 'A';

            object obj1 = var1;
            object obj2 = var2;
            object obj3 = var3;

            ushort conVar1 = Convert.ToUInt16(obj1);
            byte conVar2 = Convert.ToByte(obj2);
            int conVar3 = Convert.ToInt32(obj3);
            Console.WriteLine("int->boxing->(unboxing) ushort= " + var1 + " -> " + obj1 + " -> " + conVar1);
            Console.WriteLine("bool->boxing->(unboxing) byte= " + var2 + " -> " + obj2 + " -> " + conVar2);
            Console.WriteLine("char->boxing->(unboxing) int= " + var3 + " -> " + obj3 + " -> " + conVar3);
        }
    }
}
