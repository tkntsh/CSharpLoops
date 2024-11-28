using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i = 10; i>0; i--)
            {
                Console.WriteLine(i);
                if(i == 1)
                {
                    Console.WriteLine("Blast off");
                }
            }
        }
    }
}
