using System;
using System.Linq;
using System.Collections.Generic;

internal class Program
{
    private static void Main()
    {
        while (true)
        {
            int[] myNumbers = Array.Empty<int>();
            Console.WriteLine("input a number to add a number or type quit to continue: ");
            while (true)
            {
                string? input = Console.ReadLine();
                if (input?.ToLower() != "quit")
                {
                    int inputN = Convert.ToInt32(input);
                    if (!myNumbers.Contains(inputN))
                    {
                        myNumbers = myNumbers.Append(inputN).ToArray();
                    }
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("Saved input: ");
            foreach (int i in myNumbers)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("What is the max number: ");
            int maxNumber = Convert.ToInt32(Console.ReadLine());
            IEnumerable<int> newNumbers =
                from i in myNumbers
                where i <= maxNumber
                select i;
            Console.WriteLine($"Number that's under {maxNumber}: ");
            foreach (int i in newNumbers)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            IEnumerable<int> sortedNumber = newNumbers.OrderBy(i => i);
            Console.WriteLine("Sorted Number: ");
            foreach (int number in sortedNumber)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine("Start process again? Y/N : ");
            string? answer = Console.ReadLine();
            if (answer!.ToUpper() == "Y")
            {
                continue;
            }
            else
            {
                break;
            }
        }
    }
}