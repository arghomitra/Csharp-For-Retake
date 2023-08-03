namespace _03_Special
{
    internal class Program
    {
        static void Main(string[] args)
        {
          char userInput = Convert.ToChar(Console.ReadLine().ToUpper());
          int userInputInt = (int)userInput;
          if ((userInputInt>=33 && userInputInt<=47)|| (userInputInt >= 58 && userInputInt <= 64) || (userInputInt >= 91 && userInputInt <= 96) || (userInputInt >= 123 && userInputInt <= 126))
            {
                Console.WriteLine("Special charecter");
            }
          else if(userInputInt >= 48 && userInputInt <= 57)
            {
                Console.WriteLine("Degit");
            }
          else if (userInputInt >= 48 && userInputInt <= 57)
            {
            Console.WriteLine("Degit");
            }
        }
    }
}