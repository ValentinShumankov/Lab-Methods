using System;

namespace _02._Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeNominator(double.Parse(Console.ReadLine()));
       
        }
        
        
        /// <summary>
        /// Determines  school grade reult.
        /// </summary>
        /// <param name="num">The average grade nominator.</param>
        static void GradeNominator(double num)
        {
            if (num >= 2 && num <= 2.99)
            {
                Console.WriteLine("Fail");
            }
            else if (num >= 3 && num <= 3.49)
            {
                Console.WriteLine("Poor");
            }
            else if (num >= 3.50 && num <= 4.49)
            {
                Console.WriteLine("Good");
            }
            else if (num >= 4.50 && num <= 5.49)
            {
                Console.WriteLine("Very good");
            }
            else if (num >= 5.50 && num <= 6)
            {
                Console.WriteLine("Excellent");
            }
        }

    }
}
