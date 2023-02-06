/*
 * Sales Tax Method
 * 2/5/2023
 * C#.NET I
 * 
 * Instructions:
 * Answer the following questions...
 * 1. How many parameters does the method DisplaySalesTax() have?
 * 2. How many arguments must be passed to the DisplaySalesTax() method? Why?
 * 3. What is the difference between a parameter and an argument?
 * 4. What can be used as an argument? What must be true about an argument and
 *    a parameter?
 * 5. What does tax.ToString("C") do?
 * 6. How many parameters can a method have?
 * 7. In what order are arguments passed to parameters?
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTaxMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplaySalesTax(12.99M, 0.07M);
            DisplaySalesTax(35.67M, 0.015M);

            decimal myPurchase;
            const decimal WI_SALES_TAX = 0.055M;
            Console.Write("How much was the total? >> ");
            myPurchase = Convert.ToDecimal(Console.ReadLine());
            Console.Write("You will be charge the following in sales tax...");
            DisplaySalesTax(myPurchase, WI_SALES_TAX);
        }

        /// <summary>
        /// Calculates and displays the sales tax to be charged on
        /// a given dollar amount.
        /// </summary>
        /// <param name="saleAmount">Amount of money.</param>
        /// <param name="taxRate">Sales tax to be collected as a decimal.</param>
        private static void DisplaySalesTax(decimal saleAmount, decimal taxRate)
        {
            decimal tax;
            tax = saleAmount * taxRate;
            Console.WriteLine(tax.ToString("C"));
        }
    }
}
