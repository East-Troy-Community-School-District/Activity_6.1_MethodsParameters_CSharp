/*
 * Pass By Reference
 * 2/5/2023
 * C#.NET I
 * 
 * Instructions:
 * Answer the following questions...
 * 1. Why does the value of b change but not the value of a after
 *    the ChangeAB() method executes?
 * 2. When might reference variables be useful?
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassByReference
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2, b = 5;
            Console.WriteLine("In Main() a is " + a);
            Console.WriteLine("In Main() b is " + b);
            ChangeAB(a, ref b);
            Console.WriteLine("In Main() a is " + a);
            Console.WriteLine("In Main() b is " + b);
        }

        /// <summary>
        /// Changes the value of a and b.
        /// </summary>
        /// <param name="a">A value.</param>
        /// <param name="b">Another value.</param>
        private static void ChangeAB(int a, ref int b)
        {
            a = 4;
            b = 10;
        }
    }
}
