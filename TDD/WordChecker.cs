using System;
using System.Collections.Generic;
using System.Text;

namespace TDD
{
    public class WordChecker
    {
        public static bool ContainsChar(string input, char inputChar)
        {
            return input.Contains(inputChar.ToString().ToLower());
        }

        public static int ContainsCharCounter(string input, char inputChar)
        {
            int count = 0;

            if (!string.IsNullOrEmpty(input))
            {
                foreach (var c in input)
                {
                    if (c.ToString().ToLower() == inputChar.ToString().ToLower())
                    {
                        count++;
                    }
                }

                return count;
            }
            else return -1;
        }
    }
}
