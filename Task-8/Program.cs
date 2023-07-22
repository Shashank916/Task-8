using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 0; 
            bool isValidInput = false;

            while (!isValidInput)
            {
                Console.Write("Please enter your age: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out age))
                {
                    if (age >= 0)
                    {
                        isValidInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Age cannot be negative.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid age (an integer).");
                }
            }

            if (age < 18)
            {
                Console.WriteLine("You are a minor.");
            }
            else if (age >= 18 && age < 65)
            {
                Console.WriteLine("You are an adult.");
            }
            else
            {
                Console.WriteLine("You are a senior.");
            }
        }
    }
}
