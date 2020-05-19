using System;
using System.Collections.Generic;
using System.Text;

namespace HW11
{
    public class Shapes
    {
        public double square;
        public virtual double Square()
        {
            return square;
        }
    }
    class Rectangle : Shapes
    {
        int a = 2, b = 3;
        public override double Square()
        {
            square = a * b;
            return square;
        }
    }
    class Treangle : Shapes
    {
        int a = 2, h = 4;
        public override double Square()
        {
            square = h * 0.5 * a;
            return square;
        }
    }
    class Circle : Shapes
    {
        int r = 5;
        public override double Square()
        {
            square = Math.PI * Math.Pow(r, 2);
            return square;
        }
    }
}
