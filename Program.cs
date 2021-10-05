namespace PrimeNumbers
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            PrimeNumberEvaluation pne = new PrimeNumberEvaluation();
            string evaluator= pne.PrimeNumberCheck(17);
            Console.WriteLine(evaluator);
            pne.PrintList();
        }
    }
}
