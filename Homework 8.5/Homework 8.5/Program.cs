using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_8._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < N; i+=2)
            {
                sum += i;
            }
            Console.WriteLine(sum);
        }
    }
}
