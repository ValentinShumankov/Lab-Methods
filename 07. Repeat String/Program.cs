using System;
using System.Runtime.CompilerServices;
using System.Text;

namespace _07._Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
           StringRepeater(Console.ReadLine(), int.Parse(Console.ReadLine()));
        }
        /// <summary>
        /// The function appends the same text again and again the given amount of times.
        /// </summary>
        /// <param name="textInput">The text input</param>
        /// <param name="repetitionsNum">number of times to be added</param>
        static void StringRepeater(string textInput,int repetitionsNum)
        {
            StringBuilder text = new StringBuilder();

            for (int i = 0; i < repetitionsNum; i++)
            {
                text.Append(textInput);
            }
           
            Console.WriteLine(text);
        
        }
    }
}
