using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringReverse
{
    static public class Reverser
    {
        static public string ReverseString(string stringToReverse)
        {
            if ((stringToReverse == null) || (stringToReverse == "") || (stringToReverse.Length == 1))
            {
                return stringToReverse;
            }
            else
            {
                StringBuilder result = new StringBuilder();

                for (int i = stringToReverse.Length - 1; i >= 0; i--)
                {
                    result.Append(stringToReverse[i]);
                }
                return result.ToString();
            }
        }


        static public string ReverseStringRecurse(string stringToReverse, int length)
        {
            if (stringToReverse == null)
            {
                return null;
            }
            else if (stringToReverse.Length == 0)
            {
                return stringToReverse;
            }

            if (length == 1)
            {
                return stringToReverse;
            }
            else
            {
                return ReverseStringRecurse(stringToReverse.Substring(1, stringToReverse.Length - 1), length - 1) + stringToReverse[0].ToString();
            }
        }
    }
}
