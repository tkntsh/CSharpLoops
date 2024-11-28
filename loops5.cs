using System;

namespace loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i<21; i++)
            {
                Console.Write(i);

                if(i%2==0)
                {
                    Console.WriteLine(" Even");
                }
                else
                {
                    Console.WriteLine(" Odd");
                }
            }
        }
    }
}
