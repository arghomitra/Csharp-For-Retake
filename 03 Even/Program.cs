namespace _03_Even
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int sum = 0;
            if (a % 2 == 0)
            {
                if (b % 2 == 0)
                {
                    if ((c % 2) == 0)
                    {
                        sum = a + b + c;
                        Console.WriteLine(sum);
                    }
                }
                else
                {
                    if ((c % 2) == 0)
                    {
                        sum = a  + c;
                        Console.WriteLine(sum);
                    }
                    else
                    {
                        sum = a;
                        Console.WriteLine(sum);
                    }
                }

                

            }
            else if (b % 2 == 0)
            {
                if ((c % 2) == 0)
                {
                    sum = b + c;
                    Console.WriteLine(sum);
                }
                else
                {
                Console.WriteLine(b);
                }
                
            }
            else
            {
                sum = c;
                Console.WriteLine(sum);
            }
        }
    }
}