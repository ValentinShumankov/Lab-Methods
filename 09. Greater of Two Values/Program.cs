using System;
using System.Data;

namespace _09._Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string dataType = Console.ReadLine();
            if (dataType == "int")
            {
                int one = int.Parse(Console.ReadLine());
                int two = int.Parse(Console.ReadLine());
                Console.WriteLine(BiggerValue(one, two));
            }
            if (dataType == "char")
            {
                char one = char.Parse(Console.ReadLine());
                char two = char.Parse(Console.ReadLine());
                Console.WriteLine(BiggerValue(one, two));
            }
            if (dataType == "string")
            {
                string one = Console.ReadLine();
                string two = Console.ReadLine();
                Console.WriteLine(BiggerValue(one, two));
            }

        }
        /// <summary>
        /// Returns the bigger of two intigers
        /// </summary>
        /// <param name="one"></param>
        /// <param name="two"></param>
        /// <returns></returns>
        static int BiggerValue(int one, int two)
        {
            int compare = one.CompareTo(two);
            if (compare > 0)
            {
                return one;
            }
            else if (compare < 0)
            {
                return two;
            }
            else
            {
                return 0;

            }
        }

        /// <summary>
        /// Returns the higher in alphabet character
        /// </summary>
        /// <param name="one"></param>
        /// <param name="two"></param>
        /// <returns></returns>
        static char BiggerValue(char one, char two)
        {
            int compare = one.CompareTo(two);
            if (compare > 0)
            {
                return one;
            }
            else if (compare < 0)
            {
                return two;
            }
            else
            {
                return (char)0;
            }
        }


        /// <summary>
        /// Return the the higher combinet value of positions in alphabetical order text.
        /// </summary>
        /// <param name="one"></param>
        /// <param name="two"></param>
        /// <returns></returns>
        static string BiggerValue(string one, string two)
        {
            int compare = one.CompareTo(two);
            if (compare > 0)
            {
                return one;
            }
            else if (compare < 0)
            {
                return two;
            }
            else
            {
                return "";

            }
        }
    }
}
