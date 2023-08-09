namespace _04_Roman_to_decimal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string roman = Console.ReadLine();
            for (int i = 0;i< roman.Length;i++)
            {
                switch (roman[i])
                {
                    case 'D':
                    Console.WriteLine(500);
                    break;
                    case 'M':
                        Console.WriteLine(1000);
                        break;
                    case 'C':
                        Console.WriteLine(100);
                        break;
                    case 'L':
                        Console.WriteLine(50);
                        break;
                    case 'X':
                        Console.WriteLine(10);
                        break;
                    case 'V':
                        Console.WriteLine(5);
                        break;
                    case 'I':
                        Console.WriteLine(1);
                        break;

                }
            }

        }
    }
}