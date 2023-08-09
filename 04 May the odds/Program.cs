namespace _04_May_the_odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());//1
            int num2 = int.Parse(Console.ReadLine());//10

            int start = Math.Min(num1, num2);
            int end = Math.Max(num1, num2);

            int store = 1;

            for (int i = start; i <= end; i++)
            {
                if (i%2 !=0)
                {
                    store = store*i;
                }
            }
            Console.WriteLine(store);
        }
    }
}