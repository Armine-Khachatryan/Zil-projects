using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string booltext = Console.ReadLine();
            int planet = Convert.ToInt32(booltext);
            if (planet == 0)
            {
                Console.WriteLine("mercury");
            }
            else if (planet == 1)
            {
                Console.WriteLine("venus");
            }
            else if (planet == 2)
            {
                Console.WriteLine("earth");
            }
            else if (planet == 3)
            {
                Console.WriteLine("mars");
            }
            else if (planet == 4)
            {
                Console.WriteLine("jupiter");
            }
            else if (planet == 5)
            {
                Console.WriteLine("saturn");
            }
            else if (planet == 6)
            {
                Console.WriteLine("uranus");
            }
            else if (planet == 7)
            {
                Console.WriteLine("neptune");
            }
            else if (planet == 8)
            {
                Console.WriteLine("pluto");
            }
            else
            {
                Console.WriteLine("wrong planet");
            }
        }
    }
}

