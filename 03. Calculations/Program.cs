using System;

namespace _03._Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator(Console.ReadLine(), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
        }

        static void Calculator(string nominator,int num1,int num2)
        {
            switch (nominator)
            {
                case "add":
                    Console.WriteLine(num1 + num2);
                    break;
                case "multiply":
                    Console.WriteLine(num1 * num2);
                    break;
                case "subtract":
                    Console.WriteLine(num1 - num2);
                    break;
                case "divide":
                    Console.WriteLine(num1 / num2);
                    break;
                default:
                    break;
            }
        }
   
    
    
    }
}
