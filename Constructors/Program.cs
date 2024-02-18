internal class Program
{
    private static void Main(string[] args)
    {
        Customer customer = new Customer();
        Customer customer1 = new Customer { Id = 1, FirstName = "Engin", LastName = "Demiroğ", City = "Ankara" };  // Default Constructor
        Customer customer2 = new Customer(2, "Ömer", "Yılmaz", "Kocaeli");
    }

    class Customer
    {
        // Dönüş Tipi Yoktur
        public Customer() // Default Constructor
        {
            Console.WriteLine("Bu blok çalışır");
        }

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