using HW._12;
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            MotorcycleRepository moto = new MotorcycleRepository();
            moto.StackRepository();
            while (true)
            {
                Console.Write("Введите команду (list, create, delete, find, update): ");
                string command = Console.ReadLine();
                if (command.Equals("list"))
                {
                    moto.GetMotorcycles();
                    Console.ReadKey();
                    Console.Clear();
                }
                if (command.Equals("find"))
                {
                    moto.GetMotorcycleByID();
                    Console.ReadKey();
                    Console.Clear();
                }
                if (command.Equals("create"))
                {
                    moto.CreateMotorcycle();
                    Console.ReadKey();
                    Console.Clear();
                }
                if (command.Equals("update"))
                {
                    moto.UpdateMotorcycle();
                    Console.ReadKey();
                    Console.Clear();
                }
                if (command.Equals("delete"))
                {
                    moto.DeleteMotorcycle();
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }
}
