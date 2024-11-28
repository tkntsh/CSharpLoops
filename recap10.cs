using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int greenBottles = 10;

            do
            {
                if (greenBottles == 1)
                {
                    Console.WriteLine(greenBottles + " green bottle sitting on the wall,\n\t" + greenBottles + " green bottles sitting on the wall," +
                    "\n\tAnd if one green bottle should accidentally fall\n\tThere will be no green bottles sitting on the wall");
                    break;
                }
                int lessBottle = greenBottles - 1;
                Console.WriteLine(greenBottles + " green bottles sitting on the wall,\n\t" + greenBottles + " green bottles sitting on the wall," +
                    "\n\tAnd if one green bottle should accidentally fall\n\tThere will be " + lessBottle + " green bottles sitting on the wall");
                
                greenBottles--;
            }while(greenBottles > 0);
        }
    }
}

