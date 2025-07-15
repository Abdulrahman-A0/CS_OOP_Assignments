namespace OOP_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>()
            {
                new Student(1,"Abdulrahman","aaa@gmail.com","5"),
                new Student(2,"Ali","hhh@gmail.com","4"),
                new Teacher(3,"Ahmed","sss@gmail.com",".Net"),
                new AdminStaff(4,"Mohamed","mmm@gmail.com","Coordinator")
            };

            foreach (Person person in persons)
                Console.WriteLine($"{person.GetDetails()}\n");
        }
    }
}
