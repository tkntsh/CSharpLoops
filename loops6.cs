using System;

namespace loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i<11; i++)
            {
                Console.WriteLine(num*i);
            }
        }
    }
}
