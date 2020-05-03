using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            while (number > 0)
            {
                int digit = number % 10;
                sum += digit;
                number /= 10;
            }
            Console.WriteLine(sum);
        }
    }
}

