using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercitiuClasa
{
    public class University
    {
        enum Person
        {
            Teachers,
            Studens
        };
    }

    public class Person
    {
        enum Identity
        {
            FirstName,
            LastName,
            BirthDate,
            Gender
        }
    }

    public class Student
    {
        enum student
        {
            Id,
            Marks
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person Feliciu = new Person();
            Feliciu = Person.Students.
        }
    }
}
