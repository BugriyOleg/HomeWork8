using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BankCreditProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Початкові значення
            double totalDebt = 700; // Загальна сума боргу
            double monthlyPayment = 100; // Сума щомісячного платежу
            int remainingPayments = 7; // Кількість залишених платежів

            // Виклик методу для визначення стану кредиту
            CheckCreditStatus(totalDebt, monthlyPayment, remainingPayments);

            Console.ReadKey();
        }

        static void CheckCreditStatus(double totalDebt, double monthlyPayment, int remainingPayments)
        {
            // Розрахунок залишку боргу
            double remainingDebt = totalDebt - (monthlyPayment * remainingPayments);

            if (remainingDebt > 0)
            {
                // Якщо є борг
                double overpayment = monthlyPayment * (7 - remainingPayments);
                Console.WriteLine($"Залишок боргу: {remainingDebt} грн");
                Console.WriteLine($"Сума переплати: {overpayment} грн");
                Console.WriteLine($"Клієнт має ще {remainingPayments} платежі(-в) для погашення.");
            }
            else if (remainingDebt == 0)
            {
                // Якщо борг повністю погашено
                Console.WriteLine("Борг повністю погашено. Клієнт відсутній у списку боржників.");
            }
            else
            {
                // Якщо є переплата
                double overpayment = Math.Abs(remainingDebt);
                Console.WriteLine($"Клієнт переплатив {overpayment} грн.");
            }
        }
    }
}
