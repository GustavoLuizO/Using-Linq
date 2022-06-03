using System;
using System.Collections.Generic;
using System.Linq;

namespace _5_TakeAndSkip_WHILE_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string> { "One", "start", "more", "end", "thing" };
            List<string> result = Count1.GetStartThroughEnd(list);
            foreach (string item in list)
                Console.WriteLine(item);
        }

        public static class Count1
        {
            // Return all words in the sequence between "start" (inclusive)
            // and "end" (non-inclusive)
            // For example, if given { "One", "start", "more", "end", "thing" } ...
            // this method should return { "start", "more" }
            public static List<string> GetStartThroughEnd(List<string> words)
            {
                return words.TakeWhile(x => x!= "start").SkipWhile(x => x != "end").ToList();
            }
        }
    }
}
