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
            string positiveNegative = "Positive";
            string evenOdd = "Even";
            Console.WriteLine("Please enter a whole number: ");
            int num = int.Parse(Console.ReadLine());

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

            Console.WriteLine("The number is {0} and it is {1}", positiveNegative, evenOdd);




        }
    }
}
