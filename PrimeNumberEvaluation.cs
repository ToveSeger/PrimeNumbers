namespace PrimeNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class PrimeNumberEvaluation
    {
        //List that holds the prime numbers added by the user
        private List<int> PrimeNumberList = new List<int>();

        /// <summary>
        /// Method to check whether a number is a prime number or not. If number is one or less, method returns right away.
        /// Otherwhise further division is carried out in another method and returns result to this method. 
        /// </summary>
        /// <param name="number">Number to check</param>
        /// <returns>String that describes if the number is a prime number or not</returns>
        public string PrimeNumberCheck(int number)
        {   
            if (number <= 1) return "This is not a prime number and has not been added to you prime number list.";
            bool prime = DivideNumber(number);
            if (prime)
            {
                PrimeNumberList.Add(number);
                return "This is a prime number and has been added to your prime number list";
            }
            else return "This is not a prime number and has not been added to you prime number list.";
        }

        /// <summary>
        /// Method that divides the given number with the square root of every number that is less than or equal with the square root of the given number. 
        /// </summary>
        /// <param name="number">Number to divide</param>
        /// <returns>True if number is a prime number, otherwhise false.</returns>
        public bool DivideNumber(int number)
        {
            bool prime=true;
            int divideWith = 2;
            double sqrRootOfNumber = Math.Sqrt(number);

            while (divideWith <= sqrRootOfNumber && prime)
            {
                double check = number % divideWith;
                if (number % divideWith == 0) return !prime;
                divideWith++;
            }
            return prime;
        }

        /// <summary>
        /// Method to check whether a number is a prime number or not. If number is one or less, method returns right away.
        /// Otherwhise further division is carried out in another method and returns result to this method.  
        /// </summary>
        /// <param name="number">Number to check</param>
        /// <returns>True if number is prime number, otherwhise false.</returns>
        public bool PrimeNumberCheckBool(int number)
        {
            if (number <= 1) return false;
            if (number % 2 == 0 && number != 2) return false;
            bool prime = DivideNumber(number);
            if (prime)
            {
                return true;
            }
            else return false;
        }

        /// <summary>
        /// Method to print all values in the user's prime number list
        /// </summary>
        public void PrintList()
        {
            Console.WriteLine("Your list of prime numbers:");
            Console.WriteLine(String.Join(",", PrimeNumberList));
        }

        /// <summary>
        /// Method to add the next prime number to the user's prime number list.
        /// The number is decided based on the current highest value in the list, and the next, higher prime number is added. 
        /// </summary>
        public void AddNextPrimeNumber() 
        {
            if (PrimeNumberList.Count!=0)
            {
                PrimeNumberList.Sort();
                int lastListIndex = PrimeNumberList.Count - 1;
                int currentHighestNumber = PrimeNumberList[lastListIndex];
                int nextPrimeNumber = currentHighestNumber + 1;
                bool isNumberprime = false;

                while (!isNumberprime)
                {
                    isNumberprime = PrimeNumberCheckBool(nextPrimeNumber);
                    if (!isNumberprime) nextPrimeNumber++;
                    if (isNumberprime) PrimeNumberList.Add(nextPrimeNumber);
                }

                Console.WriteLine($"Current highest prime number:{currentHighestNumber}");
                Console.WriteLine($"Thus next prime number is {nextPrimeNumber} & has been added to the list");
            }

            else Console.WriteLine("The list has no items, please add prime numbers first.");
        }
    }
}
