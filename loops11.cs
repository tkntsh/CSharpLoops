using System;

namespace loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 1;

            while(x<101)
            {
                if(x%2 != 0)
                {
                    Console.WriteLine(x);
                }
                x++;
            }
        }
    }
}
