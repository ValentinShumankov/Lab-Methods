using System;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace _10._Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            numbers = Math.Abs(numbers);

            int even = EvenDigitDevider(numbers);
            int odd = OddDigitDevider(numbers);
          
            Console.WriteLine(even * odd);

        }

        /// <summary>
        /// Devides the odd numbers and gives sum of the back
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static int OddDigitDevider(int n)
        {
            string numbers = n.ToString();
            int oddSum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (int.Parse(numbers[i].ToString()) % 2 != 0)
                {
                    oddSum += int.Parse(numbers[i].ToString());
                }

            }
            return oddSum;
        }

        /// <summary>
        ///  Devides the even numbers and gives sum of the back
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static int EvenDigitDevider(int n)
        {
            string numbers = n.ToString();
            int evenSum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (int.Parse(numbers[i].ToString()) % 2 == 0)
                {
                    evenSum += int.Parse(numbers[i].ToString());
                }

            }
            return evenSum;
        }
    }
}
