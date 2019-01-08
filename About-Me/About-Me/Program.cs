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

            tryValid = false;   // Resets flag to false for next question
            uint q2 = 0;
            while (!tryValid)
            {
                try
                {
                    tryValid = true;
                    q2 = Birthyear();
                }
                catch (Exception e)
                {
                    tryValid = false;
                    Console.WriteLine(e.Message);
                }
            }
            if (q2 == 1982)
            {
                Console.WriteLine("Correct! I was born in August of 1982 which makes me 36.");
                correct++;
            }
            else
            {
                Console.WriteLine("Wrong!");
            }
        }

        public static string FavColor()
        {
            Console.Write("What is my favorite color? ");
            string ans = Console.ReadLine();
            return ans;
        }

        public static uint Birthyear()
        {
            Console.Write("In what year was I born? ");
            string ans = Console.ReadLine();
            return Convert.ToUInt32(ans);
        }

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
