using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_03
{
    internal class AdminStaff : Person
    {

        public string Role { get; set; }
        public AdminStaff(int id, string name, string email, string role) : base(id, name, email)
        {
            Role = role;
        }

        public override string GetDetails()
        {
            return $"ID: {Id}, Name: {Name}, Email {Email}, Role: {Role}";
        }
    }
}
