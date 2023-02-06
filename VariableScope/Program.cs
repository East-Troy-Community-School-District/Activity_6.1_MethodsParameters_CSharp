/*
 * Variable Scope
 * 2/5/2023
 * C#.NET I
 * 
 * Instructions:
 * Answer the following questions...
 * 1. What is a local variable? Give an example!
 * 2. What is a global variable? Give an example!
 * 3. Why does a in Main() not change after the Mystery()
 *    method executes?
 * 4. Why does c in Main() change after the AnotherMystery() 
 *    method executes?
 * 5. Uncomment line 39. Why is there an error?
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableScope
{
    class Program
    {
        private static int c = 8;

        static void Main(string[] args)
        {
            int a = 12;
            Console.WriteLine("In Main() a is " + a);
            Mystery();
            Console.WriteLine("In Main() a is " + a);

            Console.WriteLine("In Main() c is " + c);
            AnotherMystery(5);
            Console.WriteLine("In Main() c is " + c);
            //Console.WriteLine("In Main() b is " + b);
        }

        /// <summary>
        /// It's a mystery.
        /// </summary>
        private static void Mystery()
        {
            int a = 354;
            Console.WriteLine("In method a is " + a);
        }

        /// <summary>
        /// Even more mysteries.
        /// </summary>
        /// <param name="b">An int value.</param>
        private static void AnotherMystery(int b)
        {
            Console.WriteLine("In method b is " + b);
            c = 16;
        }
    }
}
