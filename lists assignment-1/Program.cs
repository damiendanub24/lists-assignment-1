using System;
using System.Collections.Generic;

namespace ListsProgrammingAssignments
{
    class Program
    {
        static void Main(string[] args)
        {
            //partone();
            parttwo();
        }

        public static void partone()
        {
            Random random = new Random();
            List<string> colors = new List<string>();
            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"Enter color #{i}: ");
                string colorInput = Console.ReadLine();
                colors.Add(colorInput);
            }
            Console.WriteLine("\nAll colors in the list:");
            Console.WriteLine(string.Join(", ", colors));
            int randomColorIndex = random.Next(0, colors.Count);
            Console.WriteLine($"\nRandomly selected color at index {randomColorIndex}: {colors[randomColorIndex]}");

            Console.WriteLine("\n--------------------------------------------------\n");
        }
        public static void parttwo()
        {
            Random random = new Random();
            List<int> numbers = new List<int>();
            Console.Write("How many numbers do you need? ");
            int count = int.Parse(Console.ReadLine());
            Console.Write("Enter the minimum value: ");
            int minValue = int.Parse(Console.ReadLine());
            Console.Write("Enter the maximum value: ");
            int maxValue = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                int randNum = random.Next(minValue, maxValue + 1);
                numbers.Add(randNum);
            }
            Console.WriteLine("\n[Part 1] Initial list of random numbers:");
            PrintList(numbers);
            Console.Write("\n[Part 2] Enter a number to count its occurrences: ");
            int targetCountNum = int.Parse(Console.ReadLine());
            int occurrenceCount = 0;
            foreach (int num in numbers)
            {
                if (num == targetCountNum)
                {
                    occurrenceCount++;
                }
            }
            Console.WriteLine($"The number {targetCountNum} appears {occurrenceCount} time(s) in the list.");
            Console.Write("\n[Part 3] Enter a number to replace with zero: ");
            int targetReplaceNum = int.Parse(Console.ReadLine());
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == targetReplaceNum)
                {
                    numbers[i] = 0;
                }
            }
            Console.WriteLine($"All occurrences of {targetReplaceNum} have been replaced with 0.");
            Console.WriteLine("\n[Part 4] List after replacing values:");
            PrintList(numbers);
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i] = 0;
            }
            Console.WriteLine("\n[Part 5] All values in the list have been reset to zero.");
            Console.WriteLine("\n[Part 6] List after resetting to zeros:");
            PrintList(numbers);
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i] = random.Next(minValue, maxValue + 1);
            }
            Console.WriteLine("\n[Part 7] The list has been refilled with new random numbers.");
            Console.WriteLine("\n[Part 8] Final list with new random numbers:");
            PrintList(numbers);
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
        static void PrintList(List<int> list)
        {
            Console.WriteLine(string.Join(" ", list));
        }
    }
}