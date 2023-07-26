namespace _02_Radius
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double area =Convert.ToDouble(Console.ReadLine()) ;
            //r = √(A / π).
            double pi = Math.PI;
            double r = Math.Sqrt(area/pi);
            double result = Math.Round(r, 2);
            Console.WriteLine(result.ToString("N2"));
        }
    }
}