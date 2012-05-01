﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            String toBeReversed = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum";

            StringBuilder result = new StringBuilder(); 

            for (int i = toBeReversed.Length-1; i >= 0; i--)
            {
                result.Append(toBeReversed[i]);
            }

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
