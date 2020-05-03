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
            if (A < B) 
            {
                int sum = 0;
                for (int i = A; i <= B; i++)
                {
                    sum += i;
                }
                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine("wrong");
            }


        }
    }
}
