

namespace _04_Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int number;
            bool success = int.TryParse(input, out number);
            if (success && number >0)
            {
                int factorial = 1;
                for (int i = 1;i<=number;i++)
                {
                    factorial *= i;
                }
                Console.WriteLine(factorial);

            }
            else
            {
                Console.WriteLine( "Crezy Input!");
            }
        }
    }
}