namespace AutoImplementedProperties
{
    // Ref: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/auto-implemented-properties

    // This class is mutable. Its data can be modified from
    // outside the class.
    class Customer
    {
        // Auto-implemented properties for trivial get and set
        public double TotalPurchases { get; set; }
        public string Name { get; set; }
        public int CustomerId { get; set; }

        // Constructor
        public Customer(double purchases, string name, int id)
        {
            TotalPurchases = purchases;
            Name = name;
            CustomerId = id;
        }

        // Methods
        public string GetContactInfo() { return "ContactInfo"; }
        public string GetTransactionHistory() { return "History"; }

        // .. Additional methods, events, etc.
    }

    class Program
    {
        static void Main()
        {
            // Intialize a new object.
            Customer cust1 = new Customer(4987.63, "Northwind", 90108);

            // Modify a property.
            cust1.TotalPurchases += 499.99;
        }
    }
}
