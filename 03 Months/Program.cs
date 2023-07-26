namespace _03_Months
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.WriteLine("January");
                    break;
                    case 2:
                    Console.WriteLine("Faburary");
                    break;
                    case 3:
                    Console.WriteLine("March");
                    break;
                    case 4:
                    Console.WriteLine("April");
                    break;
                    case 5:
                    Console.WriteLine("May");
                    break;
                    case 6:
                    Console.WriteLine("June");
                    break;
                    case 7:
                    Console.WriteLine("July");
                    break;
                    case 8:
                    Console.WriteLine("August");
                    break;
                    case 9:
                    Console.WriteLine("September");
                    break;
                    case 10:
                    Console.WriteLine("Öct");
                    break;
                    case 11:
                    Console.WriteLine("Nov");
                    break;
                    case 12:
                    Console.WriteLine("Dec");
                    break;

                    default: 
                    Console.WriteLine("crazy input");
                    break;
                    
            }
        }
    }
}