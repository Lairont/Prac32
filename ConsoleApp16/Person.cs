using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    abstract class Person
    {
        string name;
        string surname;
        DateTime dateofbirth;

        public DateTime Dateofbirth { get => dateofbirth; set => dateofbirth = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }

        public Person(string name, string surname, DateTime dateOfBirth)
        {
            this.Name = name;
            this.Surname = surname;
            Dateofbirth = dateofbirth;
        }

        public abstract void Print();

        public abstract int Age();
    }
}
