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
                string number;
                Console.WriteLine("enter a number and print its digits in words, for example entered 123:");
                number = Console.ReadLine();
                PrintWord(number);
                Console.WriteLine();
                Console.WriteLine("Press Q o q to quit.");
                Console.WriteLine();
                userInput = Console.ReadLine();
            }
        }

        static void PrintWord(string number)
        {
            int i, length = number.Length;

            for (i = 0; i < length; i++)
            {
                PrintValue(number[i]);
            }
        }


        static void PrintValue(char digit)
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
