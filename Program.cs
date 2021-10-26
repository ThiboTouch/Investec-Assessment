using Investec_Assessment.Extensions;
using System;

namespace Investec_Assessment
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Enter text to be analysed");

            Console.ForegroundColor = ConsoleColor.White;
            var textInput = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Enter which operations to do on the supplied text:\n‘1’ for a duplicate character check,\n‘2’ to count the number of vowels,\n‘3’ to check if there are more vowels or non vowels,\nOr any combination of ‘1’, ‘2’ and ‘3’ to perform multiple checks.", ConsoleColor.Yellow);

            Console.ForegroundColor = ConsoleColor.White;
            var operation = Console.ReadLine().ToCharArray();

            Console.ForegroundColor = ConsoleColor.Green;
            foreach (char o in operation)
            {
                switch (o)
                {
                    case '1':
                        Console.WriteLine(textInput.CheckDuplicates());
                        break;
                    case '2':
                        Console.WriteLine(textInput.CountUniqueVowels());
                        break;
                    case '3':
                        Console.WriteLine(textInput.EvaluateVowelNonVowel());
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Failed to perform the specified operation for the key {o}. Please choose a valid operation.", ConsoleColor.Yellow);
                        break;
                }
            }

            Console.ReadKey();
        }
    }
}
