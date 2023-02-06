/*
 * Rocket Ship
 * 2/5/2023
 * C#.NET I
 * 
 * Instructions:
 * Consider the following questions...
 * 1. Must methods appear above or below the Main() method?
 * 2. What is a method's header? Give an example!
 * 3. What is a method's body? Give an example!
 * 4. What is a call? Give an example!
 * 5. How many times can a method be called?
 * 6. Can two methods have the same name?
 * 7. Above each method Visual Studio tells you the number of references
 *    a method has. What does this mean?
 * 8. What can a method contain?
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocketShip
{
    class Program
    {
        /// <summary>
        /// Displays a 3 line tall cone.
        /// </summary>
        private static void DisplayCone()
        {
            Console.WriteLine("   /\\");
            Console.WriteLine("  /  \\");
            Console.WriteLine(" /    \\");
            Console.WriteLine("/      \\");
        }

        static void Main(string[] args)
        {
            DisplayCone();
            for (int i = 0; i < 6; i++)
            {
                DisplayBody();
            }
            DisplayCone();
        }

        /// <summary>
        /// Displays a 6 line tall rectangle.
        /// Represents a body part of a rocket.
        /// </summary>
        private static void DisplayBody()
        {
            Console.WriteLine("+------+");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("|      |");
            }
            Console.WriteLine("+------+");
        }
    }
}
