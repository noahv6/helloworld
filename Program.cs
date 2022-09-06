using System;

namespace deliverable_1 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string stg = "hello, World! (2)";
            Console.WriteLine(stg);

            Console.WriteLine("Enter username: ");
            string username = Console.ReadLine();
            Console.WriteLine("Enter user's age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Username is: " + username + " and the age is " + age);


        }
    }
}
