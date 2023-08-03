namespace _03_Curzon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            int number;
            bool success = int.TryParse(num, out number);
            if (success || number>0)
            {
                int power = (int)Math.Pow(2, number) + 1;
                int devider = 2 * number + 1;
                if (power % devider ==0) 
                {
                    Console.WriteLine("T");
                }
                else
                {
                    Console.WriteLine("F");
                }
            }
            else
            {
                Console.WriteLine("crazy input");
            }

        }
    }
}