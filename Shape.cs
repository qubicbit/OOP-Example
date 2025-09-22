namespace OOP_Example //polymorphism
{
    public class Shape
    {
        // Properties
        public string Name { get; set; }
        public bool IsFilled { get; set; }


        public virtual double GetArea() // Virtual method to be overridden
        {
            return 0; // Default implementation
        }
        public virtual void DisplayArea()
        {
            Console.WriteLine($"Area: {GetArea()}");
        }

        // Methods
        public void GetInfo()
        {
            string fillStatus = IsFilled ? "Filled" : "Not filled"; //Derived value
            Console.WriteLine($"This is a {Name} and it is {fillStatus}.");
        }
    }
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius; // Area of circle
        }

        public override void DisplayArea()

        {
            Console.WriteLine($"The area of the circle is: {GetArea()}");
        }
    }
}
