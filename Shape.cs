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
}
