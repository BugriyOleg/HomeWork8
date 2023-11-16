using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть кількість клієнтів (N): ");
        int n = int.Parse(Console.ReadLine());

        // Розрахунок факторіалу за допомогою стека
        long factorial = CalculateFactorialWithStack(n);

        // Розрахунок кількості можливих маршрутів
        long routes = factorial;

        Console.WriteLine($"Кількість можливих маршрутів доставки: {routes}");
    }

    static long CalculateFactorialWithStack(int n)
    {
        Stack<int> stack = new Stack<int>();
        stack.Push(n);

        long result = 1;

        while (stack.Count > 0)
        {
            int current = stack.Pop();

            if (current == 0 || current == 1)
            {
                result *= 1;
            }
            else
            {
                result *= current;
                stack.Push(current - 1);
            }
        }

        return result;
    }
}
