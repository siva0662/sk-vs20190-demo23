using System;

// 'new' modifier will hide the base class implementation

namespace Demo
{
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void Print()
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }
    }

    class Developer : Employee
    {
        public new void Print() // hides the base class implementation
        {
            Console.WriteLine($"{FirstName} {LastName} Developer");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Developer developer = new Developer { FirstName = "Sazid", LastName = "Shaik" };
            developer.Print();
        }
    }
}
