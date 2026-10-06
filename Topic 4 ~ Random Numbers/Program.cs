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

            int numberOne = generator.Next();
            int numberTwo = generator.Next(10);
            int numberThree = generator.Next(5, 10);
        }
    }
}
