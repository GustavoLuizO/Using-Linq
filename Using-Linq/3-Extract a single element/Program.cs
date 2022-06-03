using System;
using System.Collections.Generic;
using System.Linq;

namespace _3_Extract_a_single_element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<string> list = new List<string> { "Jose", "A", "Beher", "Carro" };
            Console.WriteLine(SingleValue1.GetFirstSingleLetterWord(list));
            Console.WriteLine(SingleValue1.GetLastWordWithHerInIt(list));
            Console.WriteLine(SingleValue1.GetFifthWordIfItExists(list));
            Console.WriteLine(SingleValue1.GetLastWordIfAny(list));
        }

        public static class SingleValue1
        {
            // Return the first word with just one letter in it, out of a sequence of words.
            // There will always be at least one.
            public static string GetFirstSingleLetterWord(IEnumerable<string> words)
            {
                return words.First(w => w.Length == 1);
            }

            // Return the last word that contains the substring "her" in it.
            // There will always be at least one.
            public static string GetLastWordWithHerInIt(IEnumerable<string> words)
            {
                return words.Last(w => w.Contains("her"));
            }

            // Return the fifth word in the sequence, if there is one. If there are
            // fewer than 5 words, then return null.
            public static string GetFifthWordIfItExists(IEnumerable<string> words)
            {
                return words.ElementAtOrDefault(4);
            }

            // Return the last word in the sequence. If there are no words in
            // the sequence, return null.
            public static string GetLastWordIfAny(IEnumerable<string> words)
            {
                return words.LastOrDefault();
            }
        }
    }
}
