using System;

namespace Csharrpday3
{
    class problemonstr
    {
        public static void problem()
        {
            Console.WriteLine("Enter numbers separated by '-':");
            var input = Console.ReadLine();
            var str = input.Split("-");

            // Parse the input strings to integers
            int[] numbers = Array.ConvertAll(str, int.Parse);

            // Sort the numbers
            Array.Sort(numbers);

            // Check for consecutive numbers
            bool isConsecutive = true; // Assume they are consecutive until proven otherwise

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] != numbers[i - 1] + 1)
                {
                    isConsecutive = false; // Found a gap
                    break;
                }
            }

            // Output the result
            if (isConsecutive)
            {
                Console.WriteLine("Consecutive");
            }
            else
            {
                Console.WriteLine("Not consecutive");
            }
        }
    }
}