using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3
{
    class Program
    {
        static void Main(string[] args)
        {
             // tarberak 1
             string text = Console.ReadLine();
             int number = Convert.ToInt32(text); //1612
             int a = number / 1000;
             int x = number % 1000;
             int b = x / 100;
             int y = x % 100;
             int c = y / 10;
             int d = y % 10;
             int sum = a*a + b*b + c*c + d*d;
             Console.WriteLine(sum);

            // tarberak 2
            string text = Console.ReadLine();
            int number = Convert.ToInt32(text);//1612
            int d = number % 10;
            number /= 10;
            int c = number % 10;
            number /= 10;
            int b = number % 10;
            number /= 10;
            int a = number % 10;
            int sum = a * a + b * b + c * c + d * d;
            Console.WriteLine(sum); 






        }
    }
}
