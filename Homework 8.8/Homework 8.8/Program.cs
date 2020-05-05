using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_8._8
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());
            if (A<B)
            {
                for (int i = A; i <= B; i++)
                {
                    if (i % 3 == 0) 
                    {
                        Console.WriteLine(i);
                        break;
                    }     
                }
            }
            else
            {
                Console.WriteLine("nothing");
            }
        }
    }
}
