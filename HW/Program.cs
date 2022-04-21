using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace ExercisesConsole
{
    public class Program2
    {
        //enter a number and print its digits in words, for example entered 123 => one two three  
        public static void Main(string[] args)
        {
            string userInput = Console.ReadLine();
            while (userInput != "Q" && userInput != "q")
            {

                Console.Clear();
                string N;
                Console.WriteLine("enter a number and print its digits in words, for example entered 123:");
                N = Console.ReadLine();
                printWord(N);
                Console.WriteLine();
                Console.WriteLine("Press Q o q to quit.");
                Console.WriteLine();
                userInput = Console.ReadLine();
            }
        }

        static void printWord(string N)
        {
            int i, length = N.Length;

            for (i = 0; i < length; i++)
            {
                printValue(N[i]);
            }
        }


        static void printValue(char digit)
        {
            switch (digit)
            {
                case '0':
                    Console.Write("Zero ");
                    break;

                case '1':
                    Console.Write("One ");
                    break;

                case '2':
                    Console.Write("Two ");
                    break;

                case '3':
                    Console.Write("Three ");
                    break;

                case '4':
                    Console.Write("Four ");
                    break;

                case '5':
                    Console.Write("Five ");
                    break;

                case '6':
                    Console.Write("Six ");
                    break;

                case '7':
                    Console.Write("Seven ");
                    break;

                case '8':
                    Console.Write("Eight ");
                    break;

                case '9':
                    Console.Write("Nine ");
                    break;
            }
        }
    }
}
