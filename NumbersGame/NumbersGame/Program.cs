﻿using System;

namespace NumbersGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numbers Game Yay! but lets break it");
            try
            {
                //StartSequence method called
                StartSequence();
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("There was an error in your input");
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("Application has run");
                Console.ReadLine();
            }
        } //end of Main

        /// <summary>
        /// StartSequence method with logic
        /// </summary>
        static void StartSequence()
        {
            //Prompt to do the thingy
            Console.WriteLine("Enter a Number greater than Zero if you are a hero");
            //User input
            string userResponse = Console.ReadLine();
            //Conversion from a string to an integer
            int number = Convert.ToInt32(userResponse);
            //Instantiate a new integer array
            int[] newArray = new int[number];
            //Calls Populate method
            Populate(newArray);
            //Stores and Calls Methods
            int returnSum = GetSum(newArray);
            int returnProduct = GetProduct(newArray, returnSum);
            decimal returnQuotient = GetQuotient(returnProduct);


        }//end of StartSequence

        static int[] Populate(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Please enter a number {i + 1} of {array.Length}");
                string userResponse = Console.ReadLine();
                int number = Convert.ToInt32(userResponse);
                array[i] = number;
            }
            return array;
        }//end of Populate

        static int GetSum(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum = array[i] + sum;
            }
            if (sum < 20) {
                throw new Exception("Value of sum is too low");
            }
            return sum;
        }

        static int GetProduct(int[] array, int sum)
        {
            try
            {
                Console.WriteLine($"Please select a random number between one and {array.Length}");
                string userResponse = Console.ReadLine();
                int number = Convert.ToInt32(userResponse);

                int product = 0;
                product = sum * array[number - 1];

                return product;
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        static decimal GetQuotient(int product)
        {
            try
            {
                Console.WriteLine($"Please enter a number to divide by {product}");
                string userResponse = Console.ReadLine();
                int number = Convert.ToInt32(userResponse);

                decimal quotient = 0;
                quotient = Decimal.Divide(product, number);

                return quotient;
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e);
                return 0;
            }
        }
        
    }//end of class
}
