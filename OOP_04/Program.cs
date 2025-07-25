﻿namespace OOP_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            /*What is the primary purpose of an interface in C#?
                a) To provide a way to implement multiple inheritance
                b) To define a blueprint for a class
                c) To declare abstract methods and properties
                d) To create instances of objects*/

            //Answer : b
            #endregion
            #region Q2
            /*Which of the following is NOT a valid access modifier for interface members in C#?
                a) private
                b) protected
                c) internal
                d) public*/

            //Answer : a
            #endregion
            #region Q3
            /*Can an interface contain fields in C#?
                a) Yes
                b) No
                c) Only if they are static
                d) Only if they are readonly*/

            //Answer : b
            #endregion
            #region Q4
            /*In C#, can an interface inherit from another interface?
                a) No, interfaces cannot inherit from each other
                b) Yes, interfaces can inherit from multiple interfaces
                c) Yes, but only if they have the same methods
                d) Only if the interfaces are in the same namespace*/

            //Answer : b
            #endregion
            #region Q5
            /*Which keyword is used to implement an interface in a class in C#?
                a) inherit
                b) use
                c) extends
                d) implements*/

            //Answer : none
            #endregion
            #region Q6
            /*Can an interface contain static methods in C#?
                a) Yes
                b) No
                c) Only if the interface is sealed
                d) Only if the methods are private*/

            //Answer : a
            #endregion
            #region Q7
            /*In C#, can an interface have explicit access modifiers for its members?
                    a) Yes, for all members
                    b) No, all members are implicitly public
                    c) Yes, but only for abstract members
                    d) Only if the interface is sealed

            Answer : a
             */
            #endregion
            #region Q8
            /*What is the purpose of an explicit interface implementation in C#?
                a) To hide the interface members from outside access
                b) To provide a clear separation between interface and class members
                c) To allow multiple classes to implement the same interface
                d) To speed up method resolution

            Answer : b
             */
            #endregion
            #region Q9
            /*In C#, can an interface have a constructor?
                a) Yes, but it must be private
                b) No, interfaces cannot have constructors
                c) Yes, but only if the interface is sealed
                d) Only if the constructor is static

            Answer : b
             */
            #endregion
            #region Q10
            /*How can a C# class implement multiple interfaces?
                    a) By using the "implements" keyword
                    b) By using the "extends" keyword
                    c) By separating interface names with commas
                    d) A class cannot implement multiple interfaces

            Answer : c 
             */
            #endregion

            #region Part2
            List<IShape> shapes = new List<IShape>()
            {
                new Circle(){Area = 24},
                new Rectangle(){Area = 30},
            };
            foreach (IShape shape in shapes)
                Console.WriteLine(shape.DisplayShapeInfo());
            #endregion
        }
    }
}
