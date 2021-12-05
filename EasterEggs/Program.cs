using System;
using System.Text.RegularExpressions;

namespace EasterEggs {
    class Program {
        static void Main(string[] args) {
            string input = Console.ReadLine();
            Regex rule = new Regex(@"(@|#)([a-z]{3,})(@|#)[^a-z0-9]*/\d{1,}/");

            foreach (Match match in rule.Matches(input)) {
                string colorMatch = Regex.Match(match.ToString(), @"(@|#)([a-z]{3,})(@|#)").ToString();
                string color = colorMatch.Substring(1, colorMatch.Length - 2);
                string amountMatch = Regex.Match(match.ToString(), @"/\d{1,}/").ToString();
                int amount = Convert.ToInt32(amountMatch.Substring(1, amountMatch.Length - 2));
                Console.WriteLine($"You found {amount} {color} eggs!");
            }
        }
    }
}