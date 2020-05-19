using System;

namespace HW11
{
    class Program
    {
        static void Main(string[] args)
        {
            Shapes[] shapes = { new Rectangle(), new Treangle(), new Circle() };

            foreach (var item in shapes)
            {
                Console.WriteLine($"This is {item.GetType().Name}. CLR Type is {item.GetType()}. Square is {item.Square()}");
            }
        }
    }
}
