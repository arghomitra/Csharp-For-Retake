using System.Text.RegularExpressions;

namespace _05_Single_ladies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine();
           StreamReader input = File.OpenText(userInput);
           string text = input.ReadToEnd();

            //girl/girls
            Regex rx = new Regex(@"\bgirls?\b", RegexOptions.IgnoreCase);
            MatchCollection matches = rx.Matches(text);
            Console.WriteLine(matches.Count + " matches found!");

            //lady/ladies
            Regex rx2 = new Regex(@"\blad(y|ies)\b", RegexOptions.IgnoreCase);
            MatchCollection matches2 = rx2.Matches(text);
            Console.WriteLine(matches2.Count + " matches found!");

            //women/woman
            Regex rx3 = new Regex(@"\bwom(a|e)n\b", RegexOptions.IgnoreCase);
            MatchCollection matches3 = rx3.Matches(text);
            Console.WriteLine(matches3.Count + " matches found!");
        }
    }
}