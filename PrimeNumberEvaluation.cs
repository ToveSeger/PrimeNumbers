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
            if (number % 2 == 0 && number != 2) return "This is not a prime number";
            else PrimeNumberList.Add(number);
            return "This is a prime number";
        }

        public void PrintList()
        {
            for (int i = 0; i < PrimeNumberList.Count; i++)
            {
                Console.WriteLine(PrimeNumberList[i]);
            }
        }

        public void AddNextPrimeNumber()
        {
            int currentHighestNumber = PrimeNumberList[PrimeNumberList.Count - 1];
        }
    }
}
