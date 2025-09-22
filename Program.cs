using System.IO.IsolatedStorage;

namespace OOP_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // base Shape instance
            Shape shape1 = new Shape();
            shape1.Name = "Generic Shape";
            shape1.IsFilled = true;
            shape1.GetInfo(); // Output: This is a Generic Shape and it is Filled.
            shape1.DisplayArea(); // Output: Area: 0


            // This in a Circle instance, not polymorphic
            Circle circle1 = new Circle();
            circle1.Name = "Circle";
            circle1.IsFilled = true;
            circle1.Radius = 10;
            circle1.GetInfo();
            circle1.DisplayArea();

            // Polymorphic Circle instance
            Shape shape2 = new Circle   //Shape reference, Circle object
            {
                Name = "Circle",
                IsFilled = true,
                Radius = 5
            };
            shape2.GetInfo();        // Output: This is a Circle and it is Filled.
            shape2.DisplayArea();   // Calls Circle's version of DisplayArea()

        }

    }
}
