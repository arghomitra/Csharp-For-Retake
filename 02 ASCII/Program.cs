namespace _02_ASCII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userInput = int.Parse(Console.ReadLine());//The number is read from the console and converted to an integer using int.Parse().
            char ascii= Convert.ToChar(userInput);

            Console.WriteLine(ascii.ToString().ToLower());
            Console.WriteLine(ascii.ToString().ToUpper());
            
        }
    }
}