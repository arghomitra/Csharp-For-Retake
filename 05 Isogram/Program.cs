

namespace _05_Isogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string result = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (!result.Contains(input[i]))
                {
                    result += input[i];
                }
            }
            if (input==result)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}