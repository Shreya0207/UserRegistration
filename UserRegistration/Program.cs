using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the User Registration Program");
            Validation regex = new Validation();
            Console.WriteLine("Enter your Email ID");
            string name = Console.ReadLine();
            bool result = regex.ValidateEmailSample(name);
            Console.WriteLine("Email ID: " + result);
        }
    }
}
