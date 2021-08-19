using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileDoWhileYT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            bool displayMenu = true;
            while (displayMenu)
            {
               displayMenu =  MainMenu();
            }
            
        }

        private static bool MainMenu()
        {
            Console.WriteLine("Enter the option");
            Console.WriteLine("1.Option 1 ");
            Console.WriteLine("2.Option 2 ");
            Console.WriteLine("3.Exit ");
            string option =Console.ReadLine();

            if(option == "1")
            {
                NumberGame();
                return true;
            }
            else if(option == "2")
            {
                GuessNumber();
                return true;
            }
            else if (option == "3")
            {
                return false; 
            }
            else
            {
                Console.Clear();
                return true;
            }
           
        }

        private static void NumberGame()
        {
            Console.Clear();
            Console.WriteLine("enter the number :");
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i < number+1; i++)
            {
                Console.Write(i + "-");
            }
            Console.ReadLine();
            MainMenu();
        }

        private static void GuessNumber()
        {
            Console.Clear();
            Random num = new Random();
            int randomNumber = num.Next(1,11);
            
            int guessCounter = 0;
            bool condition = true;
            do

            {
                Console.WriteLine("Guess the number between 1 to 10");
                int guess = int.Parse(Console.ReadLine());
                guessCounter++;
                if (randomNumber==guess )
                {
                    condition = false;
                    Console.WriteLine("Correct !  You took {0} guesses", guessCounter);
                    
                }
                else
                {
                    Console.WriteLine("Incorrect ! Please try again ");
                    
                }
              
            } while (condition);
        } 
    }
}

