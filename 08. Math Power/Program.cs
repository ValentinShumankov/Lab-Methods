using System;

namespace _08._Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            PowerCalculator(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
        }
        
        
        /// <summary>
        /// Calculates given number to the given power of that number.
        /// </summary>
        /// <param name="number">Input digit</param>
        /// <param name="power">Power of</param>
        static void PowerCalculator ( double number, double power)
        {
            double  result = Math.Pow(number, power);
           
            Console.WriteLine(result); 
        }
    }
}
