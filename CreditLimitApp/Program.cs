//Joshua Pickenpaugh
//July 25th, 2017
//Simple Console Credit Limit Calculator

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditLimitApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int intChoice = 1;

            while (intChoice == 1)
            {
                double dblCustomerTotal = 0.00;
                string strCustomerTotal;

                Console.Write("Enter balance from start of month:");
                double dblStartMonthBalance = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter total of all items charged:");
                double dblTotalItems = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter number of credit for customer this month:");
                double dblGivenCredits = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter allowed credit limit:");
                double dblAllowedCreditLimit = Convert.ToInt32(Console.ReadLine());

                dblCustomerTotal = dblAllowedCreditLimit - ((dblTotalItems - dblGivenCredits) +
                    dblStartMonthBalance);

                if (dblCustomerTotal > 0)
                {
                    strCustomerTotal = dblCustomerTotal.ToString("N2");
                    Console.WriteLine("Customer has {0} credit remaining.", strCustomerTotal);
                }
                else if (dblCustomerTotal == 0)
                {
                    strCustomerTotal = dblCustomerTotal.ToString("N2");
                    Console.WriteLine("Customer has no credits remaining.");
                }
                else
                {
                    strCustomerTotal = dblCustomerTotal.ToString("N2");
                    Console.WriteLine("Customer is {0} over credit.", strCustomerTotal);
                }

                Console.WriteLine("_____________________________________");
                Console.WriteLine("1. Enter another customer.");
                Console.WriteLine("2. EXIT");
                intChoice = Convert.ToInt32(Console.ReadLine());
            }

        }
    }
}
