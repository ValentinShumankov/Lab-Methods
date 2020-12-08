using System;

namespace _06._Calculate_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            RectangelAreaCalculator(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
        }
       
        
        /// <summary>
        /// Calculates surface area of a rectangle.
        /// </summary>
        /// <param name="wight">input wight</param>
        /// <param name="height">input height</param>
        static void RectangelAreaCalculator(int wight,int height)
        {
            Console.WriteLine(wight*height);
        }
   
    }
}
