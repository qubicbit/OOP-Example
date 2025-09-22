namespace OOP_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of Shape
            Shape shape1 = new Shape();
            shape1.Name = "Circle";
            shape1.IsFilled = false;
            shape1.GetInfo(); // Output: This is a Circle and it Not filled.

            Circle circle = new Circle();
            circle.Name = "Circle";
            circle.IsFilled = true;
            circle.Radius = 2;
            circle.GetInfo(); // Output: This is a Circle and it is Filled.
            circle.DisplayArea(); // Output: Area of the circle: 12.566370614359172


        }
    }
}
