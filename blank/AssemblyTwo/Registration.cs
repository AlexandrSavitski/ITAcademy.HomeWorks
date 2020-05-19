using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AssemblyTwo
{
    class Registration
    {
        internal string name;
        internal string surname;
        internal string ticket;
        internal bool baggage;
        internal short baggageWeight;
        internal bool handBaggage;
        internal bool declaration;
        internal string declarationBaggage;
        internal bool animals;
        internal string animalSize;
        int[] tempAnimalBox = new int[2];
        internal StringBuilder sb = new StringBuilder();

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                while (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Вы не ввели имя");
                    value = Console.ReadLine();
                }
                name = value;
            }
        }
        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                while (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Вы не ввели фамилию");
                    value = Console.ReadLine();
                }
                surname = value;
            }
        }
        public string Ticket
        {
            get
            {
                return ticket;
            }
            set
            {
                while (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Вы не ввели номер билета");
                    value = Console.ReadLine();
                }
                ticket = value;
            }
        }
        public short BaggageWeight
        {
            get
            {
                return baggageWeight;
            }
            set
            {
                while (baggageWeight == 0)
                {
                    Console.Write("Введите вес багажа (целочисленное число): ");
                    Int16.TryParse(Console.ReadLine(), out baggageWeight);
                }
            }
        }

        internal void PersonalData()
        {
            Console.Write("Введите имя: ");
            Name = Console.ReadLine();
            Console.Write("Введите фамилию: ");
            Surname = Console.ReadLine();
            Console.Write("Введите номер билета: ");
            Ticket = Console.ReadLine();
            Console.Clear();
        }
        internal void Baggage()
        {
            Console.Write("Перевозите ли вы багаж? (да/нет): ");
            string baggageRead = Console.ReadLine();
            if (baggageRead.Equals("да", StringComparison.OrdinalIgnoreCase))
            {
                baggage = true;
            }
            if (baggage)
            {
                Console.Write("Введите вес багажа: ");
                Int16.TryParse(Console.ReadLine(), out baggageWeight);
                BaggageWeight = baggageWeight;
            }

            Console.Write("Перевозите ли вы ручную кладь? (да/нет): ");
            string handbaggageRead = Console.ReadLine();
            if (handbaggageRead.Equals("да", StringComparison.OrdinalIgnoreCase))
            {
                handBaggage = true;
            }

            Console.Write("Имеется ли багаж подлежащий декларированию? (да/нет): ");
            string declarationRead = Console.ReadLine();
            if (declarationRead.Equals("да", StringComparison.OrdinalIgnoreCase))
            {
                declaration = true;
            }
            if (declaration)
            {
                Console.Write("Введите декларируемый багаж отделяя наименования \";\": ");
                declarationBaggage = Console.ReadLine();
            }

            Console.Write("Перевозите ли вы животных? (да/нет): ");
            string animalsRead = Console.ReadLine();
            if (animalsRead.Equals("да", StringComparison.OrdinalIgnoreCase))
            {
                animals = true;
            }
            if (animals)
            {
                Console.Write("Введите необходимый размер контейнера для перевозки (длинна/высота) через пробел, см: ");
                animalSize = Console.ReadLine();
                String[] animalBox = animalSize.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                Int32.TryParse(animalBox[0], out tempAnimalBox[0]);
                Int32.TryParse(animalBox[1], out tempAnimalBox[1]);
                while (tempAnimalBox[0] == 0)
                {
                    Console.Write("Введите необходимую длинну контейнера (целочисленное число): ");
                    Int32.TryParse(Console.ReadLine(), out tempAnimalBox[0]);
                }
                while (tempAnimalBox[1] == 0)
                {
                    Console.Write("Введите необходимую высоту контейнера (целочисленное число): ");
                    Int32.TryParse(Console.ReadLine(), out tempAnimalBox[1]);
                }
            }
            Console.Clear();
            Console.WriteLine("Спасибо за регистрацию!");
        }
        internal void BoardingPass()
        {
            Random rand = new Random();
            string terminal = "\"A\"";
            sb.Append($"Ваш посадочный талон\n" +
                    $"Имя: {Name}\n" +
                    $"Фамилия: {Surname}\n" +
                    $"Номер билета: {Ticket}\n");
            if (baggage)
            {
                terminal = "\"B\"";
                sb.Append($"Багаж: {rand.Next(1000000, 9999999)}\n"); //какаято присваемая id для багажа
            }
            if (declaration)
            {
                terminal = "\"C\"";
                sb.Append($"На декларацию: {declarationBaggage}\n");
            }
            if (animals)
            {
                terminal = "\"D\"";
                sb.Append($"Перевозка животных: {tempAnimalBox[0]}x{tempAnimalBox[1]} id: {rand.Next(1000000, 9999999)}\n");
            }
            sb.Append($"Пожалуйста пройдите к терминалу {terminal}\n");
            Console.WriteLine(sb.ToString());
        }
    }
}
