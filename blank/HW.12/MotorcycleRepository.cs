using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace HW._12
{
    class MotorcycleRepository : Motorcycle, IRepository
    {
        List<Motorcycle> moto = new List<Motorcycle>(3);
        public void StackRepository()
        {
            moto.Add(new Motorcycle() { Id = 1, Name = "Honda", Model = "CRB", Value = 250, Year = 2003, Odometr = 8000 });
            moto.Add(new Motorcycle() { Id = 2, Name = "Suzuki", Model = "ATV", Value = 50, Year = 2012, Odometr = 7000 });
            moto.Add(new Motorcycle() { Id = 3, Name = "Minsk", Model = "R250", Value = 100, Year = 2016, Odometr = 1200 });
        }

        public void GetMotorcycleByID()
        {
            Console.Write("Введите ID: ");
            int id = 0;
            Int32.TryParse(Console.ReadLine(), out id);
            var find = moto.Find(x => x.Id == id);
            Console.WriteLine($"ID: {find.Id} Name: {find.Name} Model: {find.Model} Value: {find.Value} Year: {find.Year} Odomert: {find.Odometr}");
        }

        public void GetMotorcycles()
        {
            foreach (var item in moto)
            {
                Console.WriteLine($"ID: {item.Id} Name: {item.Name} Model: {item.Model} Value: {item.Value} Year: {item.Year} Odomert: {item.Odometr}");
            }
        }

        public void CreateMotorcycle()
        {
            Console.Write("Введите ID: ");
            int id = 0;
            Int32.TryParse(Console.ReadLine(), out id);
            Console.Write("Введите Name: ");
            string name = Console.ReadLine();
            Console.Write("Введите Model: ");
            string model = Console.ReadLine();
            Console.Write("Введите Value: ");
            int value = 0;
            Int32.TryParse(Console.ReadLine(), out value);
            Console.Write("Введите Year: ");
            int year = 0;
            Int32.TryParse(Console.ReadLine(), out year);
            Console.Write("Введите Odometr: ");
            int odometr = 0;
            Int32.TryParse(Console.ReadLine(), out odometr);
            moto.Add(new Motorcycle() { Id = id, Name = name, Model = model, Value = value, Year = year, Odometr = odometr});
        }

        public void UpdateMotorcycle()
        {
            Console.Write("Введите ID: ");
            int idMoto = 0;
            Int32.TryParse(Console.ReadLine(), out idMoto);
            var find = moto.Find(x => x.Id == idMoto);
            Console.WriteLine($"ID: {find.Id} Name: {find.Name} Model: {find.Model} Value: {find.Value} Year: {find.Year} Odomert: {find.Odometr}");
            Console.Write("Введите ID: ");
            int id = 0;
            Int32.TryParse(Console.ReadLine(), out id);
            Console.Write("Введите Name: ");
            string name = Console.ReadLine();
            Console.Write("Введите Model: ");
            string model = Console.ReadLine();
            Console.Write("Введите Value: ");
            int value = 0;
            Int32.TryParse(Console.ReadLine(), out value);
            Console.Write("Введите Year: ");
            int year = 0;
            Int32.TryParse(Console.ReadLine(), out year);
            Console.Write("Введите Odometr: ");
            int odometr = 0;
            Int32.TryParse(Console.ReadLine(), out odometr);
            moto[moto.IndexOf(find)] = new Motorcycle() { Id = id, Name = name, Model = model, Value = value, Year = year, Odometr = odometr};
        }

        public void DeleteMotorcycle()
        {
            Console.Write("Введите ID: ");
            int id = 0;
            Int32.TryParse(Console.ReadLine(), out id);
            var find = moto.Find(x => x.Id == id);
            moto.Remove(moto[moto.IndexOf(find)]);
        }
    }
}
