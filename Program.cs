namespace OOP_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a Shape reference pointing to a Circle object 
            // Abstraction and Polymorphism in action
            Shape circle = new Circle
            {
                Name = "Circle",
                IsFilled = true,
                Radius = 5.0
            };
            //circle.GetInfo(); // Display shape details
            //circle.DisplayArea(); // Show calculated area

            // Create a shape reference pointing to a Rectangle object
            Shape rectangle = new Rectangle
            {
                Name = "Rectangle",
                IsFilled = false,
                Length = 4.0,
                Width = 6.0
            };

            // Create a shape reference pointing to a Triangle object
            Shape triangle = new Triangle
            {
                Name = "Triangle",
                IsFilled = true,
                Base = 3.0,
                Height = 4.0
            };
            // create an array of shapes to demonstrate polymorphism
            var shapes = new Shape[] { circle, rectangle, triangle };

            // loop through the array and display info and area for each shape
            foreach (Shape shape in shapes)
            {
                Console.WriteLine("\n--- New Shape Object ---\n");
                shape.GetInfo();
                shape.DisplayArea();
            }
        }
    }
}
