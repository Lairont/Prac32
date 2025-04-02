using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            bool flag = true;
            do
            {
                Console.Write("Введите персону: ");
                string metka = Console.ReadLine();
                switch (metka)
                {
                    case "а":
                    case "А":
                        Applicant applicant = Applicant.Enter();
                        people.Add(applicant);
                        applicant.Print();  
                        break;
                    case "п":
                    case "П":
                        Teacher teacher = Teacher.Enter();
                        people.Add(teacher);
                        teacher.Print();
                        break;
                    case "с":
                    case "С":
                        Student student = Student.Enter();
                        people.Add(student);
                        student.Print();
                        break;
                    case "д":
                    case "Д":
                        OutputPersonsInRange(people);
                        break;
                    default:
                        Console.WriteLine("Ошибка");
                        break;
                }
                Console.WriteLine();
            } while (flag);
        }

        static void OutputPersons(List<Person> persons)
        {
            Console.Clear();
            foreach (Person person in persons)
            {
                person.Print();
                Console.WriteLine();
            }
        }

        static void OutputPersonsInRange(List<Person> persons)
        {
            Console.Clear();
            Console.WriteLine("Введите нижнюю границу диапазона возраста:");
            int min = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите верхнюю границу диапазона возраста:");
            int max = int.Parse(Console.ReadLine());
            List<Person> personsInRange = persons.Where(p => p.Age() >= min && p.Age() <= max).ToList();
            if (personsInRange.Count > 0)
            {
                OutputPersons(personsInRange);  
            }
            else
            {
                Console.WriteLine("Нет персон в указанном диапазоне возраста.");
            }
        }
    }
}
