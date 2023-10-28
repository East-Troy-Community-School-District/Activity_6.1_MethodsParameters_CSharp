/*
 * T-Shirt
 * Pawelski
 * 10/28/2023
 * Developing Desktop Applications
 * 
 * Instructions:
 * Answer the following questions...
 * 1. Which parameter in the MakeTShirt() method is optional?
 * 2. What is the default argument for the optional parameter?
 * 
 * Next, modify the method so that size has a default argument
 * of "large". Check your code by uncommenting line 31. You should
 * see the message "You ordered a large t-shirt with the logo I love C#! on it."
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TShirt
{
    class Program
    {
        static void Main(string[] args)
        {
            MakeTShirt("medium");
            MakeTShirt("large", "I love Java!");
            //MakeTShirt();
        }

        /// <summary>
        /// Makes a t-shirt with a given size and logo.
        /// </summary>
        /// <param name="size">Size of the t-shirt.</param>
        /// <param name="logo">Logo to be on the t-shirt.</param>
        private static void MakeTShirt(string size, string logo = "I love C#!")
        {
            Console.WriteLine("You ordered a " + size + " t-shirt with the logo "
                + logo + " on it.");
        }
    }
}
