using System;

namespace Variable_Watford_Koby
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declares an interger to store a favorite number
            int favoriteNumber;
            // Booleans initialized to false for juming and running
            bool isJumping = false, isRunning = false;
            // Declared randome float variable
            float myFloat;
            // Assigning the favoriteNumber to 6
            favoriteNumber = 6;
            //  myFloat to 54.65
            myFloat = 54.65f;
            // Initializing constant finalGrade to 90
            const double finalGrade = 90.0;

            // Print out all variables to console
            Console.WriteLine("Favorite #: " + favoriteNumber);
            Console.WriteLine("Jumping: " + isJumping);
            Console.WriteLine("Running: " + isRunning);
            Console.WriteLine("Random Floating #: " + myFloat);
            Console.WriteLine("Final Grade: " + finalGrade);
        }
    }
}