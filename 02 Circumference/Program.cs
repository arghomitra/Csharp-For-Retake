namespace _02_Circumference
{
    internal class Program
    {
        static void Main(string[] args)
        {
           decimal l = Convert.ToDecimal(Console.ReadLine());
           decimal w = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine(2 * (l + w));
        }
    }
}