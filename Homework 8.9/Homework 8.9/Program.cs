using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_8._9
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            double sum = 0;
            for (int i = 1; i <= N; i++)
            {
                sum = sum + (double)1/i;
            }
            Console.WriteLine(sum);
        }
    }
}
