namespace PrimeNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class ProgramLogic
    {
        PrimeNumberEvaluation pne = new PrimeNumberEvaluation();

        /// <summary>
        /// Menu to present the Prime Number Evaluator and it's choices. 
        /// </summary>
        public void Menu()
        {
            int menuChoice = 0;
            while (menuChoice != 4)
            {
                try
                {
                    Console.WriteLine("**********************************");
                    Console.WriteLine("Welcome to Prime Number Evaluator");
                    Console.WriteLine("What do you want to do?");
                    Console.WriteLine("**********************************");
                    Console.WriteLine("1. Evaluate if a number is a prime number (and add it to my prime number list)");
                    Console.WriteLine("2. Print my list of prime numbers");
                    Console.WriteLine("3. Add next prime number in my list");
                    Console.WriteLine("4.Exit");
                    Console.WriteLine("**********************************");
                    int userInput = Convert.ToInt32(Console.ReadLine());
                    MenuSwitch(userInput);
                }
                catch (Exception)
                {
                    Console.WriteLine("Wrong type of input, requires a number, please try again");
                }
            }
        }
        /// <summary>
        /// Switches between different methods depending on user input. 
        /// </summary>
        /// <param name="menuChoice">User input from menu</param>
        public void MenuSwitch(int menuChoice)
        {  
                switch (menuChoice)
                {
                    case 1:
                     Console.WriteLine("Enter the number you want to check:");
                     int numberToCheck = Convert.ToInt32(Console.ReadLine());
                     Console.WriteLine(pne.PrimeNumberCheck(numberToCheck)); 
                        break;
                    case 2:
                        pne.PrintList();
                        break;
                    case 3:
                        pne.AddNextPrimeNumber();
                        break;
                    case 4:
                        Console.WriteLine("Bye!");
                        System.Environment.Exit(0);
                    break;
                    default:
                    Console.WriteLine("Woops, went a bit fast huh? Please choose a valid number.");
                        break;
                }       
        }
    }
}
