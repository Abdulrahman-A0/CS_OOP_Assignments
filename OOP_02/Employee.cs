using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_02
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public SecurityLevel SecurityLevel { get; set; }
        public decimal Salary { get; set; }
        public HiringDate HireDate { get; set; }
        public Gender Gender { get; set; }

        public Employee(int id, string name, decimal salary, HiringDate hireDate, SecurityLevel securityLevel, Gender gender)
        {
            Id = id;
            Name = name;
            Salary = salary;
            HireDate = hireDate;
            SecurityLevel = securityLevel;
            Gender = gender;
        }

        public override string ToString()
        {
            return $"Id: {Id} " +
                $"\nName: {Name} " +
                $"\nSalary: {Salary.ToString("c")} " +
                $"\nGender: {Gender} " +
                $"\nSecurity Level: {SecurityLevel} " +
                $"\nHireDate: {HireDate.Day}-{HireDate.Month}-{HireDate.Year}";
        }

    }
}
