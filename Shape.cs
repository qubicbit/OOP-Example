namespace OOP_Example
{
    public class Shape
    {
        //Field hidden from outside the class
        private string name;

        // public Property with backing field that gives controlled access to the private field 'name'
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //Property 
        public bool IsFilled { get; set; }

        // Methods
        public void GetInfo()
        {
            string fillStatus = IsFilled ? "Filled" : "Not filled"; //Derived value
            Console.WriteLine($"This is a {Name} and it is {fillStatus}.");
        }
    }
    public class Circle : Shape
    {   // private field
        private double radius;
        //public property with validation, accsess to private field
        public double Radius
        {
            get { return radius; }
            set
            {
                if (value > 0)
                    radius = value;
                else
                    Console.WriteLine("Radius must be positive.");
            }
        }
        public double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
        public void DisplayArea()
        {
            Console.WriteLine($"Area of the circle: {GetArea()}");
        }
    }
}
