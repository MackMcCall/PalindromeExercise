using PalindromeExercise;
using System;
using Xunit;
using Xunit.Sdk;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("mom", true)]
        [InlineData("dad", true)]
        [InlineData("poppa", false)]
        [InlineData("tenet", true)]
        [InlineData("Hannah", true)]
        [InlineData("no", false)]
        [InlineData("Race Car", true)]
        [InlineData("Go hang a salami; I'm a lasagna hog!", true)]
        [InlineData("", false)]
        [InlineData(" ", false)]
        public void IsAPalindromeTest(string word, bool expected)
        {
            //Arrange
            WordSmith wordSmith = new WordSmith();

            //Act
            bool actual = wordSmith.IsAPalindrome(word);

            //Assert
            Assert.Equal(expected, actual);

        }
    }
}
