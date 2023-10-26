using System;
using System.Collections.Generic;

namespace TestProQ
{ 
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 60, 105, 420 };
            List<string> replacedNumbers = NumberChange.ReplaceNumbers(numbers);

            Console.WriteLine(string.Join(", ", replacedNumbers)); 
        }
    }
}