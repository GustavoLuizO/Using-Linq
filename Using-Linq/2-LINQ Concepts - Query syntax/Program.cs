using System;
using System.Collections.Generic;
using System.Linq;

namespace _2_LINQ_Concepts___Query_syntax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<string> invalues = new List<string> { "gibteste", "fateste", "heron", "ibexron", "jackalope" };
            IEnumerable<string> result = QuerySyntax1.FilterAndSort(invalues, "teste");
            foreach (string value in result)
                Console.WriteLine(value);
        }

        public static class QuerySyntax1
        {
            public static IEnumerable<string> FilterAndSort(IEnumerable<string> inValues, string pattern)
            {
                return from value in inValues
                       where value.Contains(pattern)
                       orderby value
                       select value;
            }
        }
    }
}
