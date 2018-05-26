using System;
using System.Collections.Generic;
using System.Text;

namespace Homework01Liabrary
{
    class Account : Person
    {
        private int id;
        private string userName;
        private string email;
        private string password;


        public Account(int id, string userName, string email, string password, string firstName, string lastName, DateTime birthDate) 
            : base(firstName, lastName, birthDate)
        {
            this.id = id;
            this.userName = userName;
            this.email = email;
            this.password = password;
        }
    }
}
