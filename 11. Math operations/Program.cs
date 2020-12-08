using System;

namespace _11._Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperation(int.Parse(Console.ReadLine()),
                Console.ReadLine(), 
                int.Parse(Console.ReadLine()));
        }


        /// <summary>
        /// Perform simple mathematical calculation "+", "-", "/", "*".
        /// </summary>
        /// <param name="numA"></param>
        /// <param name="nominalSigh"></param>
        /// <param name="numB"></param>
        static void MathOperation(int numA,string nominalSigh,int numB)
        {
            int result = 0;
            switch (nominalSigh)
            {
                case "*":
                    result = numA * numB;
                    break;
                case "+":
                    result = numA + numB;
                    break;
                case "/":
                    result = numA / numB;
                    break;
                case "-":
                    result = numA - numB;
                    break;
                default:
                    Console.WriteLine("Wrong operator sighn!" +
                        "");
                    break;
            }
            Console.WriteLine(result);
        
        }
    }
}
