namespace OOP_Example
{
    public class Shape
    {
        // Properties
        public string Name { get; set; }
        public bool IsFilled { get; set; }

        // Methods
        public void GetInfo()
        {
            string fillStatus = IsFilled ? "Filled" : "Not filled"; //Derived value
            Console.WriteLine($"This is a {Name} and it is {fillStatus}.");
        }
    }
    // Derived classes, Circle inherits from Shape methods and properties
    public class Circle : Shape
    {
        // Property specific to Circle class
        public double Radius { get; set; }
        // Method to calculate area of the circle
        public double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
        public void DisplayArea()
        {
            Console.WriteLine($"Area of the circle is: {GetArea()}");
        }
    }

    // Another derived class, Rectangle inherits from Shape methods and properties
    public class Rectangle : Shape
    {   // Properties specific to Rectangle class
        public double Width { get; set; }
        public double Height { get; set; }

        // Method to calculate area of the rectangle
        public double GetArea()
        {
            return Width * Height; // Area = width * height
        }
        public void DisplayArea()
        {
            Console.WriteLine($"Area of the rectangle is: {GetArea()}");
        }
    }
}
