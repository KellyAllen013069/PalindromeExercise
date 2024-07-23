using System;
using System.Linq;

namespace PalindromeExercise;

public class WordSmith
{
    public bool IsAPalindrome(string word)
    {
        //fun but not efficient:
        var reversed =  new string(word.ToLower().ToCharArray().Reverse().ToArray());
        return word.ToLower() == reversed;
    }
}