using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_03
{
    internal class Teacher : Person
    {
        public string Subject { get; set; }

        public Teacher(int id, string name, string email, string subject) : base(id, name, email)
        {
            Subject = subject;
        }

        public override string GetDetails()
        {
            return $"ID: {Id}, Name: {Name}, Email {Email}, Subject: {Subject}";
        }
    }
}
