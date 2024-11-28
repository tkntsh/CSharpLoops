using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many holidays have you used: ");
            
            int totalHolidays = 28;
            int holidaysUsed = Convert.ToInt32(Console.ReadLine());
            int totalHolidaysLeft = totalHolidays - holidaysUsed;

            Console.WriteLine("You have " + totalHolidaysLeft + " holidays left");
        }
    }
}
