namespace OOP_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] empArr = new Employee[3];
            empArr[0] = new Employee(1, "Mohamed", 10000, new HiringDate(10, 10, 2020), SecurityLevel.DBA, Gender.Male);
            empArr[1] = new Employee(2, "Ahmed", 15000, new HiringDate(5, 12, 2023), SecurityLevel.guest, Gender.Male);

            empArr[2] = new Employee(
                3,
                "Ali",
                12000,
                new HiringDate(3, 9, 2021),
                SecurityLevel.DBA | SecurityLevel.guest | SecurityLevel.Developer | SecurityLevel.secretary,
                Gender.Male);

            foreach (Employee emp in empArr)
                Console.WriteLine($"{emp}\n___________________________");
        }
    }
}
