using System;
using System.Collections.Generic;
using System.Text;

namespace Homework01Liabrary
{
    class Person
    {
        private string firstName;
        private string lastName;
        private DateTime birthDate;

        public Person(string firstName, string lastName, DateTime birthDate)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthDate = birthDate;
        }
    }
}
