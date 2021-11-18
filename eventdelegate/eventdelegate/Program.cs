using System;

public delegate void MyDelegate();
namespace eventdelegate
{
    class Person
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public event MyDelegate MyEvent;
        public void UpdateLastName(string lastname)
        {
            LastName = lastname;
            if (MyEvent != null)
                MyEvent();
        }
    }
    class Program
    {
        static void Main()
        {

            Person person = new Person { FirstName = "Sowmya", LastName = "Vadlmudi" };

            person.MyEvent += Person_MyEvent;

            person.UpdateLastName("Shaik");
        }

        private static void Person_MyEvent()
        {
            Console.WriteLine("Person LastName Updated");
        }
    }
}
    

