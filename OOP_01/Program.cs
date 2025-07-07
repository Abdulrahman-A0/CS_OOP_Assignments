using System;

namespace OOP_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            /*1-Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members.
                Then, write a C# program that prints out all the days of the week using this enum.*/
            //**********************************************************************************************

            //foreach (var name in Enum.GetNames<WeekDays>())
            //{
            //    Console.WriteLine(name);
            //} 
            #endregion

            #region Q2
            /*2.Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person"
                objects and populate it with data. Then, write a C# program to display the details of all the persons
                in the array.*/
            //******************************************************************************************************

            //Person[] persons = new Person[3]
            //{
            //    new Person { Name = "Ali", Age = 20 },
            //    new Person { Name = "Ahmed", Age = 18 },
            //    new Person { Name = "Abdulrahman", Age = 20 },
            //};
            //foreach (Person person in persons)
            //{
            //    Console.WriteLine(person);
            //}
            #endregion

            #region Q3
            /*3.	Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as its members.
             Write a C# program that takes a season name as input from the user and displays the corresponding month
             range for that season. Note range for seasons 
            ( spring march to may , summer june to august , autumn September to November , winter December to February)*/
            //***********************************************************************************************************

            //Season season;
            //do
            //{
            //    Console.Write("Enter Season Name" +
            //        "\n(Spring, Summer, Autumn, Winter) : ");
            //} while (!Enum.TryParse(Console.ReadLine(), out season));

            //string range = season switch
            //{
            //    Season.Spring => "march to may",
            //    Season.Summer => "june to august",
            //    Season.Autumn => "September to November",
            //    Season.Winter => "December to February",
            //    _ => "Invalid Season"
            //};
            //Console.WriteLine($"{season} Starts From {range}");
            #endregion

            #region Q4
            /*Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.
            ●	Create Variable from previous Enum to Add and Remove Permission from variable,
                check if specific Permission is existed inside variable*/
            //****************************************************************************************

            //Permissions permissions = new Permissions();
            //permissions = Permissions.Read;
            //permissions |= Permissions.Execute;
            //permissions |= Permissions.write;
            //permissions ^= Permissions.write;
            //Console.WriteLine(permissions);
            //Console.WriteLine("Enter Permission to Check if you have or not: ");

            //Permissions perCheck;
            //do
            //{
            //    Console.Write("Enter Permission to check" +
            //        "\n(Read, write, Delete, Execute) : ");
            //} while (!Enum.TryParse(Console.ReadLine(), out perCheck));

            //if ((permissions & perCheck) == perCheck)
            //    Console.WriteLine($"You Have The {perCheck} permission");
            //else
            //    Console.WriteLine($"You Don't Have The {perCheck} permission");
            #endregion

            #region Q5
            /*5.Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members.
                Write a C# program that takes a color name as input from the user and displays a message
                indicating whether the input color is a primary color or not.*/
            //**************************************************************************************************

            //Console.Write("Enter Color Name: ");
            //string color = Console.ReadLine();
            //if (Enum.TryParse(color, true, out Colors cl))
            //    Console.WriteLine($"{color} Is a primary color");
            //else
            //    Console.WriteLine($"{color} Isn't a primary color");
            #endregion

            #region Q6
            /*6.Create a struct called "Point" to represent a 2D point with properties "X" and "Y". 
            Write a C# program that takes two points as input from the user and calculates the distance between them.*/
            //*********************************************************************************************************

            //int x1, y1, x2, y2;

            //do
            //{
            //    Console.Write("Enter X value For Point 1: ");
            //} while (!int.TryParse(Console.ReadLine(), out x1));
            //do
            //{
            //    Console.Write("Enter Y value For Point 1: ");
            //} while (!int.TryParse(Console.ReadLine(), out y1));
            //do
            //{
            //    Console.Write("Enter X value For Point 2: ");
            //} while (!int.TryParse(Console.ReadLine(), out x2));
            //do
            //{
            //    Console.Write("Enter Y value For Point 2: ");
            //} while (!int.TryParse(Console.ReadLine(), out y2));

            //Point point1 = new Point() { X = x1, Y = y1 };
            //Point point2 = new Point() { X = x2, Y = y2 };

            //double distance = Math.Sqrt(Math.Pow(point2.X - point1.X, 2) + Math.Pow(point2.Y - point1.Y, 2));
            //Console.WriteLine($"Distance= {distance:f}");
            #endregion

            #region Q7
            /*7. Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details
                 of 3 persons as input from the user and displays the name and age of the oldest person.*/
            //**********************************************************************************************************

            //List<Person> persons = new List<Person>();
            //persons.Add(TakePersonData());
            //persons.Add(TakePersonData());
            //persons.Add(TakePersonData());
            //Console.WriteLine(persons.FirstOrDefault(p => p.Age == persons.Max(p => p.Age)));


            #endregion
        }

        static int i = 1;
        public static Person TakePersonData()
        {
            Person person = new Person();
            Console.Write($"Enter Name of Person {i}: ");
            person.Name = Console.ReadLine();
            int age;
            do
            {
                Console.Write($"Enter Age of Person {i}: ");
            } while (!int.TryParse(Console.ReadLine(), out age));
            person.Age = age;
            ++i;
            return person;
        }
    }
}
