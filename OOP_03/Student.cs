using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_03
{
    internal class Student : Person
    {
        public string GradeLevel { get; set; }
        public Student(int id, string name, string email, string gradeLevel) : base(id, name, email)
        {
            GradeLevel = gradeLevel;
        }

        public override string GetDetails()
        {
            return $"ID: {Id}, Name: {Name}, Email {Email}, Grade Level: {GradeLevel}";
        }
    }
}
