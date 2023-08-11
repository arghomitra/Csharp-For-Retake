namespace _04_Next_Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first_num = 0;
            int second_num = 1;
            int user = int.Parse(Console.ReadLine());
            while (first_num != user)
            {
            int temp = first_num + second_num;
                first_num = second_num;
                second_num = temp;
                if (temp == user)
                {
                    Console.WriteLine(first_num+second_num);
                }
                
            }
                
            
        }
    }
}