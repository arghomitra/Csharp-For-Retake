using System;

namespace _04_smallest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int smallest = 0;

            while (true)
            {
                string input = Console.ReadLine().ToLower();

                if (input == "x")
                {
                    break;
                }

                int number;
                bool success = int.TryParse(input, out number);

                if (success)
                {
                    if (number < smallest)
                    {
                        smallest = number;
                    }
                    else if (smallest == 0)
                    {
                        smallest = number;
                    }
                }
            }

            Console.WriteLine(smallest);
        }
    }
}