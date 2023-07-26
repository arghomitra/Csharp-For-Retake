namespace _02_Odd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int integerValue = int.Parse(Console.ReadLine());
            if (integerValue/2 != 0)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}