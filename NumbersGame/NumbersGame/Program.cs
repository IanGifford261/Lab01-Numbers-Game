﻿using System;

namespace NumbersGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numbers Game Yay! but lets break it");

            //StartSequence method called
            StartSequence();
            Console.WriteLine();

        } //end of Main

        //StartSequence method with logic
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
            Console.WriteLine($"Please select a random number between one and {array.Length}");
            string userResponse = Console.ReadLine();
            int number = Convert.ToInt32(userResponse);

            int product = 0;
            product = sum * array[number - 1];

            return product;
        }
        
    }//end of class
}
