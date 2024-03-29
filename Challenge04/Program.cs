﻿using System;
using System.Collections;

namespace Substitution
{
    class Program
    {
        static void Main(string[] args)
        {
            // We have some word collection ...
            var censoredWords = new ArrayList();
            censoredWords.Add("imperdiet");
            censoredWords.Add("dolor");
            censoredWords.Add("duo");

            // and a paragraph.
            var paragraph = "Lorem ipsum dolor sit amet, imperdiet vituperata duo in, nonumy.";
            string word1 = censoredWords["imperdiet"].Replace("*****");
            string word2 = censoredWords["dolor"].Replace("*********");
            string word3 = censoredWords["duo"].Replace("***");
            Console.WriteLine(var);

            // Censor the words in paragraph by using * symbol.
            // Output example:
            // Lorem ipsum ***** sit amet, ********* vituperata *** in, nonumy.
        }
    }
}
