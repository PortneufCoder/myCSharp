﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithStrings
{
    public class StringUtility
    {
        public static string SummarizeText(string text, int maxLength = 20)
        {

            if (text.Length < maxLength)
                return text;

            {
                var words = text.Split(' ');
                var totalCharacters = 0;
                var summaryWords = new List<string>(); // need a list since arrays are immutable

                foreach (var word in words)
                {
                    summaryWords.Add(word);

                    totalCharacters += word.Length + 1; // add 1 due to space after word
                    if (totalCharacters > maxLength)
                        break;
                }

                return string.Join(" ", summaryWords) + "...";

            }
        }


    }
}
