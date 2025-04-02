using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Applicant : Person
    {
        string faculty;

        public string Faculty { get => faculty; set => faculty = value; }

        public Applicant(string name, string surname, DateTime dateOfBirth, string faculty) : base(name, surname, dateOfBirth)
        {
            Faculty = faculty;
        }

        public override void Print()
        {
            Console.WriteLine($"Абитуриент: {Name} {Surname}\n" +
                $"Дата рождения: {Dateofbirth:d}\n" +
                $"Фаультет: {Faculty}\n" +
                $"Возраст: {Age()}");
        }

        public override int Age()
        {
            int age = DateTime.Now.Year - Dateofbirth.Year;
            if (DateTime.Now.DayOfYear < Dateofbirth.DayOfYear)
            {
                age--;
            }

            return age;
        }

        public static Applicant Enter()
        {

            Console.Write("Имя абитуриента: ");
            string name = Console.ReadLine();
            Console.Write("Фамилия абитуриента: ");
            string surname = Console.ReadLine();
            Console.Write("Дата рождения: ");
            DateTime dateOfBirth = DateTime.Parse(Console.ReadLine());
            Console.Write("Факультет: ");
            string faculty = Console.ReadLine();
            Console.Clear();
            return new Applicant(name, surname, dateOfBirth, faculty);
        }
    }
}
