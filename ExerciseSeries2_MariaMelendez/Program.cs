using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseSeries2_MariaMelendez
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a C# program that reads a number and indicates wheter it is positive, negative, zero, odd or even. 

            // Variables to host default values
            string positiveNegative = "Positive";
            string evenOdd = "Even";

            // Asking input from the user and store it in num varible
            Console.WriteLine("Please enter a whole number: ");
            int num = int.Parse(Console.ReadLine());

            // if statements to test conditions
            if (num < 0)
            {
                positiveNegative = "Negative";

                if (num % 2 != 0) 
                {
                    evenOdd = "Odd";
                }
            }
            else if (num > 0)
            {
                if (num % 2 != 0)
                {
                    evenOdd = "Odd";
                }
            }
            else
            {
                positiveNegative = "Zero";
            }

            //Prompt results
            Console.WriteLine("The number is {0} and it is {1}", positiveNegative, evenOdd);




        }
    }
}
