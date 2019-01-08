using System;

namespace About_Me
{
    class Program
    {
        static void Main(string[] args)
        {
            int correct = 0;        // Counter for questions answered correctly
            bool tryValid = false;      // Flag used to continue or break out of loops containing try/catch blocks until valid input is entered 
            Console.WriteLine("Welcome to the About Me Quiz!");
            Console.WriteLine("-----------------------------");

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

            // Question 2
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
            tryValid = false;

            // Question 3
            byte q3 = 0;
            while (!tryValid)
            {
                try
                {
                    tryValid = true;
                    q3 = StatesVisited();
                }
                catch (Exception e)
                {
                    tryValid = false;
                    Console.WriteLine(e.Message);
                }
            }
            if (q3 == 12)
            {
                Console.WriteLine("Correct! I've visited 12 different states in my life so far. And counting!");
                correct++;
            }
            else
            {
                Console.WriteLine("Wrong!");
            }
            tryValid = false;

            // Question 4
            string q4 = "";
            while (!tryValid)
            {   
                try
                {
                    tryValid = true;
                    q4 = FavSmashChar();
                }
                catch (Exception e)
                {
                    tryValid = false;
                    Console.WriteLine(e.Message);
                }
            }
            if (q4.ToLower() == "samus")
            {
                Console.WriteLine("Correct! Samus is my main girl. Come see me if you wanna get blasted!");
                correct++;
            }
            else
            {
                Console.WriteLine("Wrong!");
            }
            tryValid = false;
        }

        public static string FavColor()
        {
            Console.Write("Question 1: What is my favorite color? ");
            string ans = Console.ReadLine();
            if (ans.Length == 0)    // Checks if user entered no input in a string type method and throws exception if so
            {
                throw new ArgumentException("No answer given. Please enter your answer.");  // Exception thrown for empty string instead of answer being automatically wrong
            } else
            {
                return ans;
            }
        }

        public static uint Birthyear()
        {
            Console.Write("Question 2: In what year was I born? ");
            string ans = Console.ReadLine();
            return Convert.ToUInt32(ans);
        }

        public static byte StatesVisited()
        {
            Console.Write("Question 3: How many states in the US have I visited? ");
            string ans = Console.ReadLine();
            return Convert.ToByte(ans);
        }

        public static string FavSmashChar()
        {
            Console.Write("Question 4: Who is my favorite Smash Bros character? ");
            string ans = Console.ReadLine();
            if (ans.Length == 0)
            {
                throw new ArgumentException("No answer given. Please enter your answer.");
            }
            else
            {
                return ans;
            }
        }

        //public static bool CakeOrPie()
        //{

        //}
    }
}
