using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if(age<18)
            {
                Console.WriteLine("You are too young.\nDo you want to book a different movie?");
            }
            else if(age>=18)
            {
                Console.WriteLine("You are old enough.\nWould you like to be taken to the booking screen?");
            }
        }
    }
}
