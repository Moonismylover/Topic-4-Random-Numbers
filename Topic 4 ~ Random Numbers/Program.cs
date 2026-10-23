using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic_4___Random_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Topic 4 ~ Random Numbers";

            Random generator = new Random();

            /*
            Above we declare a variable "generator" of type Random.
            We invoke the constructor of the Random class to create 
            a new instance of the Random class and assign it to the 
            variable "generator".
            */

            int numberOne = generator.Next(); // Random integer b/w 0 and Int32.MaxValue
            int numberTwo = generator.Next(10); // Random integer b/w 0 and 9
            int numberThree = generator.Next(5, 10); // Random integer b/w 5 and 9

            /* 
            
            Discription of Methods

            1. Next(): Returns a random non-negative integer.
            2. Next(Int32): Returns a random non-negative integer less than the specificed range.
            3. Next(Int32, Int32): Returns a random integer within a speicifced range.
            4. NextDouble(): Returns a random floating number greater than or equal to 0.0, and less than 1.0.

            A seed is the intial value input into a method. 

            */

            int one = generator.Next(1, 11);
            int two = generator.Next(10, 21);

            int max = 10;
            int min = 1;
            int value = generator.Next(min, max + 1);

            if (value > min && value < max)
            {
                Console.WriteLine($"The random number {value} is greater than the min {min}");
            }
            else if (max > value && value > min)
            {
                Console.WriteLine($"The random number {value} is kess than max {max}");
            }
            else if (value == min && value != max)
            {
                Console.WriteLine($"The random number {value} is equal to the min {min}");
            }
            else 
            {
                Console.WriteLine($"The random number {value} is equal to the max {max}");
            }

        }
    }
}
