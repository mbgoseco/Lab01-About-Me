using System;

namespace About_Me
{
    class Program
    {
        static int correct = 0;        // Counter for questions answered correctly
        static bool tryValid = false;      // Flag used to continue or break out of loops containing try/catch blocks until valid input is entered 
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the About Me Quiz!");

            // Question 1. Code will loop until no exception is thrown
            string q1 = "";
            while (!tryValid)
            {
                try
                {
                    tryValid = true;    // Flag flips to true so loop can be escaped UNLESS an exception is caught
                    q1 = FavColor();     // Assigns q1 to the return value of the method given by user's input
                }
                catch (Exception e)
                {
                    tryValid = false;   // Flag is set to false again on exception so loop will continue
                    Console.WriteLine(e.Message);
                    throw;
                }
            }
            if (q1.ToLower() == "yellow")
            {
                Console.WriteLine("Correct! I love the color yellow!");
                correct++;      // correct answer counter increments when user input matches correct answer
            } else
            {
                Console.WriteLine("Wrong!");
            }

             uint q2;
        }

        public static string FavColor()
        {
            Console.Write("What is my favorite color? ");
            string ans = Console.ReadLine();
            return ans;
        }

        //public static int Birthyear()
        //{

        //}

        //public static string StatesVisted()
        //{

        //}

        //public static string FavSmashChar()
        //{

        //}

        //public static bool CakeOrPie(bool isCake)
        //{

        //}
    }
}
