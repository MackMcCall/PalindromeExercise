using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string word)
        {
            if (word == null || word.Trim() == "")
            {
                return false;
            }
            else
            {
                //filtering
                string lowWord = word.ToLower();
                var noSpaceWord = lowWord.Where(x => !char.IsWhiteSpace(x));
                var filteredWord = noSpaceWord.Where(c => !char.IsPunctuation(c));
                char[] filtWordChArray = filteredWord.ToArray();
                string filteredWordStr = new string(filtWordChArray);

                //reversing
                var arrFilt = filteredWord.ToArray();
                var revArrFilt = arrFilt.Reverse().ToArray();
                string revWord = new string(revArrFilt);

                return revWord == filteredWordStr;
            }
        }
    }
}
