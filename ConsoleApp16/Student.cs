using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Student : Person
    {
        string faculty;
        int course;

        public string Faculty { get => faculty; set => faculty = value; }
        public int Course { get => course; set => course = value; }

        public Student(string name, string surname, DateTime dateOfBirth, string faculty, int course) : base(name, surname, dateOfBirth)
        {

        }

        public override void Print()
        {
            Console.WriteLine($"Студент: {Name} {Surname}\n" +
                $"Дата рождения: {Dateofbirth:d}\n" +
                $"Фаультет: {Faculty}\n" +
                $"Курс: {Course}\n" +
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

        public static Student Enter()
        {
            Console.Write("Имя студента: ");
            string name = Console.ReadLine();
            Console.Write("Фамилия студента: ");
            string surname = Console.ReadLine();
            Console.Write("Дата рождения: ");
            DateTime dateOfBirth = DateTime.Parse(Console.ReadLine());
            Console.Write("Факультет: ");
            string faculty = Console.ReadLine();
            Console.Write("Курс: ");
            int course = int.Parse(Console.ReadLine());
            Console.Clear();
            return new Student(name, surname, dateOfBirth, faculty, course);
        }
    }
}
