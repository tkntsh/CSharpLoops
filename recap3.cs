using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What number am I thinking of: ");
            
            int guessedNum = Convert.ToInt32(Console.ReadLine());

            switch(guessedNum)
            {
                case 1:
                    Console.WriteLine("Not my number\nSorry!");
                    break;
                case 2:
                    Console.WriteLine("Correct\nWell done!");
                    break;
                case 3:
                    Console.WriteLine("Not my number\nSorry!");
                    break;
                case 4:
                    Console.WriteLine("Not my number\nSorry!");
                    break;
                case 5:
                    Console.WriteLine("Not my number\nSorry!");
                    break;
                default: 
                    Console.WriteLine("Invalid input");
                    break;
            }
        }
    }
}
