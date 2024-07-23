using System;
using PalindromeExercise;
using Xunit;
using Xunit.Sdk;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("hello", false)]
        [InlineData("Radar", true)]
        [InlineData("kayak", true)]
        public void Test1(string word, bool expected)
        {
            //Arrange
            var w = new WordSmith();
            //Act
            var actual = w.IsAPalindrome(word);
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
