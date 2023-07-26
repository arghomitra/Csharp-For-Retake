namespace _02_Decimal_part
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal decimalNum = Convert.ToDecimal(Console.ReadLine()); //10.78001

            int integerValue = (int)Math.Floor(decimalNum);//10
            
            decimal result = decimalNum-integerValue;//0.78001

            Console.WriteLine(result.ToString("N6"));//0.780010
        }
    }
}