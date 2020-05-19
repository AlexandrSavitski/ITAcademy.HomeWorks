using System;

namespace AssemblyTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Registration registration = new Registration();
            ToEmail toEmail = new ToEmail();

            registration.PersonalData();
            registration.Baggage();
            registration.BoardingPass();
            string message = registration.sb.ToString();
            toEmail.SendMail(message);
            Console.WriteLine("Приятного полета!");
            Console.Read();
        }
    }
}
