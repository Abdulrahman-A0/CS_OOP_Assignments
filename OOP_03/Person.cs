using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_03
{
    internal class Person
    {
        private int id;
        private string name;
        private string email;


        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public Person(int id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
        }

        public virtual string GetDetails()
        {
            return $"ID: {Id}, Name: {Name}, Email {Email}";
        }


    }
}
