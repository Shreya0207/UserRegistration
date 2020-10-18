using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the User Registration Program");
            Validation regex = new Validation();
            Console.WriteLine("Enter your last name:");
            string name = Console.ReadLine();
            bool result = regex.ValidateName(name);
            Console.WriteLine("Last Name: " + result);
        }
    }
}
