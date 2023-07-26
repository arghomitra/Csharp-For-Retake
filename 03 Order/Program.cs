namespace _03_Order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = Convert.ToDouble(Console.ReadLine());
            double num2 = Convert.ToDouble(Console.ReadLine());
            double num3 = Convert.ToDouble(Console.ReadLine());
            string orderNumber = string.Empty;
            if (num1 > num2 && num1>num3)
            {
                orderNumber = num1.ToString();
                if (num2>num3)
                {
                    orderNumber += " "+num2.ToString()+" " + num3.ToString();
                    Console.WriteLine(orderNumber);
                }
                else
                {
                    orderNumber += " " + num3.ToString() + " " + num2.ToString();
                    Console.WriteLine(orderNumber);
                }
            }
            else if(num2 > num3 && num2>num1)
            {
                orderNumber = num2.ToString();
                if (num1 > num3)
                {
                    orderNumber += " " + num1.ToString() + " " + num3.ToString();
                    Console.WriteLine(orderNumber);
                }
                else
                {
                    orderNumber += " " + num3.ToString() + " " + num1.ToString();
                    Console.WriteLine(orderNumber);
                }
            }
            else if (num3 > num2 && num3 > num1)
            {
                orderNumber = num3.ToString();
                if (num2 > num1)
                {
                    orderNumber += " " + num2.ToString() + " " + num1.ToString();
                    Console.WriteLine(orderNumber);
                }
                else
                {
                    orderNumber += " " + num1.ToString() + " " + num2.ToString();
                    Console.WriteLine(orderNumber);
                }
            }
        }
    }
}