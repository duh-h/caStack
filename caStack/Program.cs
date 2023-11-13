using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace caStack
{
    internal class Program
    {
        public bool IsValid(string s)
        {
            Stack<char> openingParentheses = new Stack<char>();

            foreach (char c in s)
            {
                if (c == '(' || c == '{' || c == '[' || c == ')' || c == '}' || c == ']')
                {

                    if (c == '(' || c == '{' || c == '[')
                    {
                        openingParentheses.Push(c);
                    }
                    else
                    {
                        if (openingParentheses.Count == 0) return false;

                        char opening = openingParentheses.Pop();

                        if (opening == '(' && c != ')'
                            || opening == '{' && c != '}'
                            || opening == '[' && c != ']') return false;
                    }
                }
            }


            return openingParentheses.Count == 0;
        }
   

        static void Main(string[] args)
        {
            // Example usage of IsValid method
            string testString1 = "{5*[a+b]-d*(c-a) + log10}";
            string testString2 = "{5*[a+b]-d*(c-a] + log10}";


            Program program = new Program();

            Console.WriteLine($"'{testString1}' valido? {program.IsValid(testString1)}");
            Console.WriteLine($"'{testString2}' valido? {program.IsValid(testString2)}");

        }
    }
}
