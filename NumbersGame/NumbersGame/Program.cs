using System;

namespace NumbersGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numbers Game Yay! but lets break it");

            //start sequence method called
            StartSequence();
            Console.WriteLine();

        } //end of main

        static void StartSequence()
        {
            //Prompt to do the thingy
            Console.WriteLine("Enter a Numero greater than Zero if you are a hero");
            //User input
            string userResponse = Console.ReadLine();
            //Conversion from a string to an integer
            int numero = Convert.ToInt32(userResponse);
            //Instantiate a new integer array
            int[] newArray = new int[0];
        }
            
    }//end of class
}
