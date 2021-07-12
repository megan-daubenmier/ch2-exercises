using System;

namespace SearchString
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
            Console.WriteLine("Please enter the term you would like to search for:");
            string lowerCaseSentence = sentence.ToLower();
            string input = Console.ReadLine();
            string searchTerm = input.ToLower();
            int length = searchTerm.Length;
            int foundTerm = lowerCaseSentence.IndexOf(searchTerm);
            if (foundTerm == -1)
            {
                Console.WriteLine("false");
            }
            else
            {
                Console.WriteLine("The search term's length is "+ length+ " and its index is "+ foundTerm+ ".");
                string newSentence = sentence.Remove(foundTerm, length);
                Console.WriteLine(newSentence);    
            }
        }
    }
}
