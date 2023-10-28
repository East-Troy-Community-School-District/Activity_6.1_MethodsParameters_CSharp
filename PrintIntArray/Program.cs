/*
 * Print Int Array
 * Pawelski
 * 10/28/2023
 * Developing Desktop Applications
 * 
 * Instructions:
 * Modify the method so that it takes an array of doubles instead
 * of ints. Change the code in the Main() method so that the array
 * numbers stores doubles as well. 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintIntArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 6, 1, 7 };
            DisplayArray(numbers);
        }

        /// <summary>
        /// Displays the contents of the array on a single line.
        /// </summary>
        /// <param name="array">Array to be displayed.</param>
        private static void DisplayArray(int[] array)
        {
            foreach (int number in array)
            {
                Console.Write(number + " ");
            }
        }
    }
}
