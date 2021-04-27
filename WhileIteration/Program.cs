using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileIteration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            bool displayMenu = true;
            while (displayMenu == true)
            {
               displayMenu = MainMenu();
            }
        }
        private static bool MainMenu()
        {
            Console.WriteLine("Choose an Option");
            Console.WriteLine("1, Option 1");
            Console.WriteLine("2, Option 2");
            Console.WriteLine("3, Exit");
            String result = Console.ReadLine();
            if(result=="1")
            {
                PrintNumbers();
                return true;
            }
            else if(result=="2")
            {
                GuessingGame();
                return true;
            }
            else if (result=="3")
            {
                return false;

            }
            else
            {
                return true;
            }
        }
        private static void PrintNumbers()
        {
            Console.Clear();
            Console.WriteLine("Print Numbers");
            Console.WriteLine("Type a number.");
            int result = int.Parse(Console.ReadLine());
            int counter = 1;
            while(counter <= result)
            {
                Console.Write(counter);
                Console.Write("-");
                counter++;
            }
            Console.ReadLine();
        }
        private static void GuessingGame()
        {
            Console.Clear();
            Console.WriteLine("Guessing Game!");
            Random myRandom = new Random();
            int randomNumber = myRandom.Next(1, 11);
            int guesses = 0;
            bool incorrect = true;
            do
            {
                Console.WriteLine("Guess the number between 1 to 10: ");
                string result = Console.ReadLine();
                guesses++;
                if(result == randomNumber.ToString())
                {
                    incorrect = false;
                }
                else
                {
                    Console.WriteLine("Wrong! Try again.");
                }
                

            } while (incorrect);
            Console.WriteLine("Correct! It took you {0} guesses", guesses);
            Console.ReadLine();
        }
    }
}

