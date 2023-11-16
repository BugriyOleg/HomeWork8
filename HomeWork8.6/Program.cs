using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int result1 = Calculate(10, 15, 20);

            Console.WriteLine($"Результат: {result1}");

            Console.ReadLine();
        }

        static int Calculate(int a, int b, int c)
        {
            int result = a / 5 + b / 5 + c / 5;
            return result;

            
        }
    }
}