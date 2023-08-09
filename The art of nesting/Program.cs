namespace The_art_of_nesting
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("PLAYER 1: THINK OF A NUMBER BERWEEN 1 TO 20 .");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("PLAYER 2: CHOOSE A NUMER WHICH YOU U GESS");
            bool win = true;
            int count = 0;
            while (win)
            {
               
                int guess = Convert.ToInt32(Console.ReadLine());
                count ++;
                if (guess == number)
                {
                   win = false;
                }
                if (count>5)
                {
                    win = false;
                }
                Console.Beep();

            }
        }
    }
}