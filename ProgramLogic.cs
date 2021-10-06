namespace PrimeNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class ProgramLogic
    {
        PrimeNumberEvaluation pne = new PrimeNumberEvaluation();

        public void Menu()
        {
            int menuChoice = 0;
            while (menuChoice != 4)
            {
                Console.WriteLine("Welcome to prime number evaluator");
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("1. Evaluate if a number is a prime number (and add it to my prime number list)");
                Console.WriteLine("2. Print my list of prime numbers");
                Console.WriteLine("3. Add next prime number in my list");
                Console.WriteLine("4.Exit");
                int userInput = Convert.ToInt32(Console.ReadLine());
                MenuSwitch(userInput);
            }
        }

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
                     System.Environment.Exit(0);
                    break;
                    default:
                        break;
                }       
        }
    }
}
