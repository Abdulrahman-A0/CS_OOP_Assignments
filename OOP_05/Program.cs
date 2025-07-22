namespace OOP_05
{
    internal class Program
    {
        public static int i = 1;
        public static void ReadPointFromUser(out int x, out int y, out int z)
        {
            do
            {
                Console.Write($"Enter X Value for Point {i}: ");
            } while (!int.TryParse(Console.ReadLine(), out x));
            do
            {
                Console.Write($"Enter Y Value for Point {i}: ");
            } while (!int.TryParse(Console.ReadLine(), out y));
            do
            {
                Console.Write($"Enter Z Value for Point {i}: ");
            } while (!int.TryParse(Console.ReadLine(), out z));
            Console.Clear();
            i++;
        }
        static void Main(string[] args)
        {
            #region First Project
            #region Q3
            //3.Read from the User the Coordinates for 2 points P1, P2
            //(Check the input using try Pares, Parse, Convert).

            //int x, y, z;
            //ReadPointFromUser(out x, out y, out z);
            //Point3D p1 = new Point3D(x, y, z);
            //ReadPointFromUser(out x, out y, out z);
            //Point3D p2 = new Point3D(x, y, z);

            #endregion

            #region Q4
            /*4.	Try to use ==
            If (P1 == P2)   Does it work properly? 
            */

            //if (p1 == p2)
            //    Console.WriteLine("p1 Equal p2");
            //else
            //    Console.WriteLine("p1 Not Equal p2");

            // Answer : Not Working properly
            #endregion

            #region Q5
            /*5.Define an array of points and sort this array based on X & Y coordinates.*/

            //Point3D[] points =
            //{
            //    new Point3D(1,2,3),
            //    new Point3D(4,2,4),
            //    new Point3D(1,1,4),
            //};

            //Array.Sort(points);  // Implemented IComparable Interface
            //foreach (Point3D point in points)
            //    Console.WriteLine(point);
            #endregion

            #region Q6
            //Point3D p1 = new Point3D(2, 6, 7);
            //Point3D p2 = (Point3D)p1.Clone();
            //Console.WriteLine(p2);
            #endregion
            #endregion
            #region Second Project
            //Console.WriteLine(Maths.Add(5, 3));
            //Console.WriteLine(Maths.Subtract(5, 3));
            //Console.WriteLine(Maths.Multiply(5, 3));
            //Console.WriteLine(Maths.Divide(5, 2));
            #endregion
            #region Third Project
            //Duration D = new Duration(1, 10, 15);
            //Console.WriteLine(D.ToString());
            //Duration D1 = new Duration(3600);
            //Console.WriteLine(D1.ToString());
            //Duration D2 = new Duration(7800);
            //Console.WriteLine(D2.ToString());
            //Duration D3 = new Duration(666);
            //Console.WriteLine(D3.ToString());

            #endregion

        }
    }
}
