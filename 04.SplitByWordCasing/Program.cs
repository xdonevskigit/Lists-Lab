using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SplitByWordCasing
{
    class Program
    {
        static void Main(string[] args)
        {
            var separators = new char[]
            {
                ',', ';', ':', '.', '!','(', ')', '"', '\'', '\\', '/',  '[', ']',  ' '
            };
            var words = Console.ReadLine()                
                .Split(separators, StringSplitOptions.RemoveEmptyEntries);
            var lowerCaseList = new List<string>();
            var upperCaseList = new List<string>();
            var mixedCaseList = new List<string>();
            foreach (var item in words)
            {
                var type = GetType(item);
                if (type == WordType.UpperCase)
                {
                    upperCaseList.Add(item);
                }
                else if (type == WordType.LowerCase)
                {
                    lowerCaseList.Add(item);
                }
                else if (type == WordType.MixedCase)
                {
                    mixedCaseList.Add(item);
                }
            }
            Console.WriteLine("Lower-case: " + String.Join(", ", lowerCaseList));
            Console.WriteLine("Mixed-case: " + String.Join(", ", mixedCaseList));
            Console.WriteLine("Upper-case: " + String.Join(", ", upperCaseList));
            

        }

        enum WordType {UpperCase, LowerCase, MixedCase };

        private static WordType GetType(string word)
        {
            int lowerLetter = 0;
            int upperLetter = 0;

            foreach (var item in word)
            {
                if (char.IsUpper(item))
                {
                    upperLetter++;
                }
                else if (char.IsLower(item))
                {
                    lowerLetter++;
                }
            }
            if (upperLetter == word.Length)
            {
                return WordType.UpperCase;
            }
            else if (lowerLetter == word.Length)
            {
                return WordType.LowerCase;
            }
            else
            {
                return WordType.MixedCase; 
            }
        }
    }
}
