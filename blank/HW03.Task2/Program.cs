using System;

namespace HW03.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte a1 = 1;
            System.SByte a2 = 1;
            byte b1 = 2;
            System.Byte b2 = 2;
            short c1 = 3;
            System.Int16 c2 = 3;
            ushort d1 = 4;
            System.UInt16 d2 = 4;
            int e1 = 5;
            System.Int32 e2 = 5;
            uint f1 = 6;
            System.UInt32 f2 = 6;
            long g1 = 7;
            System.Int64 g2 = 7;
            ulong h1 = 8;
            System.UInt64 h2 = 8;
            char i1 = 'a';
            System.Char i2 = 'a';
            float k1 = 10;
            System.Single k2 = 10;
            double l1 = 11;
            System.Double l2 = 11;
            bool m1 = true;
            System.Boolean m2 = true;
            decimal n1 = 12;
            System.Decimal n2 = 12;
            object o1 = new object { };
            System.Object o2 = new object { };
            string p1 = "Hello";
            System.String p2 = "Hello";

            Console.WriteLine(a1.GetType() + "\n" + a2.GetType() + "\n" +
                b1.GetType() + "\n" + b2.GetType() + "\n" +
                c1.GetType() + "\n" + c2.GetType() + "\n" +
                d1.GetType() + "\n" + d2.GetType() + "\n" +
                e1.GetType() + "\n" + e2.GetType() + "\n" +
                f1.GetType() + "\n" + f2.GetType() + "\n" +
                g1.GetType() + "\n" + g2.GetType() + "\n" +
                h1.GetType() + "\n" + h2.GetType() + "\n" +
                i1.GetType() + "\n" + i2.GetType() + "\n" +
                k1.GetType() + "\n" + k2.GetType() + "\n" +
                l1.GetType() + "\n" + l2.GetType() + "\n" +
                m1.GetType() + "\n" + m2.GetType() + "\n" +
                n1.GetType() + "\n" + n2.GetType() + "\n" +
                o1.GetType() + "\n" + o2.GetType() + "\n" +
                p1.GetType() + "\n" + p2.GetType() + "\n");

        }
    }
}
