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

        static int Populate(int[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine("Please enter a number 1 of 6");
                string userResponse = Console.ReadLine();
                int numero = Convert.ToInt32(userResponse);

            }
        }
            
    }//end of class
}
