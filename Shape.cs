namespace OOP_Example
{

    public abstract class Shape
    {
        // Properties, get set accessors 
        public string Name { get; set; }
        public bool IsFilled { get; set; }

        // Abstract method to be implemented by derived classes, no body/implementation here for abstract methods
        public abstract double GetArea();

        // If define here as abstract, must implement in every derived classes
        // public abstract void DisplayArea();

        // Virtual method with a default implementation, can be overridden by derived classes
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
    // circle class inheriting from Shape class, public to allow access from other classes
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
