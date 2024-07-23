using System;

namespace PalindromeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = new WordSmith();
            var isValid = word.IsAPalindrome("kayak");
            Console.WriteLine(isValid);
        }
    }
}
