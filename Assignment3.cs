﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Assignment3
    {
        public static void Main()
        {
            string myStr;
            int i, len, vowel_count, cons_count;
            Console.WriteLine("Enter the String");
            myStr = Console.ReadLine();
            vowel_count = 0;
            cons_count = 0;
            // find length
            len = myStr.Length;
            for (i = 0; i < len; i++)
            {
                if (myStr[i] == 'a' || myStr[i] == 'e' || myStr[i] == 'i' || myStr[i] == 'o' || myStr[i] == 'u' || myStr[i] == 'A' || myStr[i] == 'E' || myStr[i] == 'I' || myStr[i] == 'O' || myStr[i] == 'U')
                {
                    vowel_count++;
                }
                else
                {
                    cons_count++;
                }
            }
            Console.Write("\nVowels in the string: {0}\n", vowel_count);
        }
    }
}