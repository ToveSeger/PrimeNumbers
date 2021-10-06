namespace PrimeNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class PrimeNumberEvaluation
    {
        private List<int> PrimeNumberList = new List<int>();

        public string PrimeNumberCheck(int number)
        {   
            if (number <= 1) return "This is not a prime number";
            bool prime = DivideNumberWithEvenNumbers(number);
            if(prime)
            {
                PrimeNumberList.Add(number);
                return "This is a prime number";
            }

            else return "This is not a prime number";           
        }

        public bool DivideNumberWithEvenNumbers(int number)
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

        
        public bool PrimeNumberCheckBool(int number)
        {
            if (number <= 1) return false;
            if (number % 2 == 0 && number != 2) return false;
            bool prime = DivideNumberWithEvenNumbers(number);
            if (prime)
            {
                //PrimeNumberList.Add(number);
                return true;
            }

            else return false;
        }

        public void PrintList()
        {
            Console.WriteLine("Your list of prime numbers:");
            for (int i = 0; i < PrimeNumberList.Count; i++)
            {
                Console.WriteLine(PrimeNumberList[i]);
            }
        }

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

                Console.WriteLine($"Nuvarande högsta nummer i listan är:{currentHighestNumber}");
                Console.WriteLine($"Nästa nummer är således {nextPrimeNumber} & har adderats till listan.");
            }

            else Console.WriteLine("The list has no items, please add prime numbers first.");
        }
    }
}
