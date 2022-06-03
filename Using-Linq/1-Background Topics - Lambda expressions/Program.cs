using System;

namespace _1_Background_Topics___Lambda_expressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = LambdaExpressions1.GetNextNumber(3);
            Console.WriteLine(result);
        }

        public static class LambdaExpressions1
        {
            public static Func<int, int> GetNextNumber = num => num + 1;
            //Expressão static cuja função recebe um int e retorna um int. 
        }
    }
}
