using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_8._6
{
    class Program
    {
        static void Main()
        {
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());
            for (int i = A; i <= B; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(B - A + 1);
        }
    }
}