using System;
using System.Collections.Generic;
using System.Linq;

namespace Extract_multiple_elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> inteiros = new List<int> { 1,2,3,4,5,6,7,8};
            var result = SkipTake1.GetThirdFourthFifthItems(inteiros);
            foreach (var item in result)
                Console.WriteLine(item);
        }

        public static class SkipTake1
        {
            // Return the 3rd, 4th, and 5th items of the provided sequence.
            public static IEnumerable<int> GetThirdFourthFifthItems(IEnumerable<int> inteiros)
            {
                return inteiros.Skip(2).Take(3);
            }
        }
    }
}
