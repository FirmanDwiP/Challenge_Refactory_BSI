using System;

namespace CountWords
{
    class Program
    {
        static void Main(string[] args)
        {
            CountWords("Hello"); // Output: 1
            CountWords("Hello World"); // Output: 2
            CountWords("Lorem ipsum dolor sit amet"); // Output: 5
        }

        static int CountWords(string value)
        {
            // Make this method to be able counting words
            string s = "This is a sentence. Also this counts. This one is also a thing.";
            string[] sentences = s.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string sentence in sentences)
            {
                Console.WriteLine(sentence.Split(' ').Length + " words in sentence *" + sentence + "*");
            }
            return true;
        }
    }
}
