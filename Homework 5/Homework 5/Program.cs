using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string boolText = Console.ReadLine();
            int planet = Convert.ToInt32(boolText);
            switch (planet)
            {
                case 0:
                    Console.WriteLine("mercury");
                    break;
                case 1:
                    Console.WriteLine("venus");
                    break;
                case 2:
                    Console.WriteLine("earth");
                    break;
                case 3:
                    Console.WriteLine("mars");
                    break;
                case 4:
                    Console.WriteLine("jupiter");
                    break;
                case 5:
                    Console.WriteLine("saturn");
                    break;
                case 6:
                    Console.WriteLine("uranus");
                    break;
                case 7:
                    Console.WriteLine("neptune");
                    break;
                case 8:
                    Console.WriteLine("pluto");
                    break;
                default:
                    Console.WriteLine("wrong planet");
                    break;
            }
        }









    }
}
