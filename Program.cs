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

            // create another instance of Shape
            Shape shape2 = new Shape();
            shape2.Name = "Rectangle";
            shape2.IsFilled = true;
            shape2.GetInfo(); // Output: This is a Rectangle and it is Filled.

        }
    }
}
