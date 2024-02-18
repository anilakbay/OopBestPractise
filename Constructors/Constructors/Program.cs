namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { Id = 19, FirstName = "Anıl", LastName = "Akbay", City = "Muğla" };

            Customer customer3 = new Customer();
            customer3.Id = 7;

            Customer customer2 = new Customer(16, "Buse", "Akbay", "Muğla");
            Console.WriteLine(customer2.FirstName);
        }

    }
    class Customer
    {
        public Customer()
        {

        }
        //default constructor
        public Customer(int id, string firstName, string lastName, string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }

}
