namespace OOP_Example
{
    //Abstraction of a Shape
    //    Define abstract class Shape
    //    Property: Name
    //    Property: IsFilled
    //    Abstract Method: GetArea()
    //    Virtual Method: DisplayArea()
    //    Method: GetInfo()

    //Define class Circle that inherits from Shape
    //    Property: Radius
    //    Override Method: GetArea()
    //    Override Method: DisplayArea()

    public abstract class Shape
    {
        // Properties
        public string Name { get; set; }
        public bool IsFilled { get; set; }

        // Abstract method to be implemented by derived classes, no body/implementation here for abstract methods
        public abstract double GetArea();
        // public abstract void DisplayArea();

        public virtual void DisplayArea()
        {
            Console.WriteLine($"Area: {Math.Round(GetArea(), 1)}");
        }

        // Methods
        public void GetInfo()
        {
            string fillStatus = IsFilled ? "Filled" : "Not filled"; //Derived value
            Console.WriteLine($"Object: {Name}, Status: {fillStatus}.");
        }
    }
    public class Circle : Shape
    {
        // Property specific to Circle
        public double Radius { get; set; }

        // Override the abstract method to provide implementation
        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
    public class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public override double GetArea()
        {
            return Length * Width;
        }

    }
    public class Triangle : Shape
    {
        public double Base { get; set; }
        public double Height { get; set; }
        public override double GetArea()
        {
            return 0.5 * Base * Height;
        }

    }
}
