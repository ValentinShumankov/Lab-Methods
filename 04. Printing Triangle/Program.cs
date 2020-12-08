using System;

namespace _04._Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            TrianglePrinter(int.Parse(Console.ReadLine()));
        }
       
        /// <summary>
        /// Prints out a number triangel in from one to ... input
        /// </summary>
        /// <param name="num">The input num, max lenght of triangle.</param>
        static void TrianglePrinter (int num)
        {
            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j +" ");
                }
                Console.WriteLine();
            }
            for (int i = num - 1; i >= 0; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
       
        }
   
    }
}
