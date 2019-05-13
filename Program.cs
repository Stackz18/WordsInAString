using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordsInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintInstructions();
            bool active = true;
            while (active)
            {
                string input = Console.ReadLine();
                string lowerCaseInput = input.ToLower();
                if (lowerCaseInput == "exit")
                {
                    active = false;
                }
                else
                {
                    string[] wordArray = input.Split(new[] { " ", ", ", ". " }, StringSplitOptions.None);
                    Console.WriteLine("The amount of words in your sentence: {0}\n", wordArray.Length);
                    PrintInstructions();
                }
            }
        }

        private static void PrintInstructions()
        {
            Console.WriteLine("Please type in a sentence and the program will check how many words are in the sentence, or type exit to leave the program: ");
        }
    }
}