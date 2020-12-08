using System;

namespace _01._Sign_of_Integer_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
           SighIndicator(int.Parse(Console.ReadLine()));
        
        }
       
        /// <summary>
        /// Determine the nominator sigh of the input digit.
        /// </summary>
        /// <param name="num">The input digit.</param>
        static void SighIndicator ( int num)
        {
            if (num < 0)
            {
                Console.WriteLine("The number {0} is negative.",num);
            }
            else if (num > 0)
            {
                Console.WriteLine("The number {0} is positive.", num);
            }
            else
            {
                Console.WriteLine("The number {0} is zero.", num);
            }
        }
   
    
    
    }
}
