﻿namespace _04_Floyd_s_triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int counter = 1;
            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= i; j++) 
                {
                    Console.Write(counter+" ");
                    counter++;
                }
                Console.WriteLine();
            }
        }
    }
}