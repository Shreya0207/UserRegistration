using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the User Registration Program");
            Validation regex = new Validation();
            Console.WriteLine("Enter your Mobile Number with country code:");
            string name = Console.ReadLine();
            bool result = regex.ValidateMobileNumber(name);
            Console.WriteLine("MobileNumber: " + result);
        }
    }
}
