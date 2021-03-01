using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { Id = 1, FirstName = "Yusuf", LastName = "Aktaş", City = "Ankara" };
            Customer customer2 = new Customer(2, "Perihan","aktaş", "ankara");
            Console.WriteLine(customer1.FirstName);
        }
    }

    class Customer 
    {
        public Customer()                //DEFAULT CONSTRUCTOR = Parametresi olmayan constructor'dur
        {

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
