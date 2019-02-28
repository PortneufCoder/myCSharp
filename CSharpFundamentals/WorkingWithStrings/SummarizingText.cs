using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithStrings
{
    public class SummarizingText
    {
        public void StringUtility()
        {
            var sentence = "Such a very very extremely awesomely outstandingly long boring shoot me in the head text!";
            const int MaxLength = 20;

            if(sentence.Length < MaxLength)
                Console.WriteLine(sentence);
            else
            {
                var words = sentence.Split(' ');
                var totalCharacters = 0;
                var summaryWords = new List<string>(); // need a list since arrays are immutable

                foreach (var word in words)
                {
                    summaryWords.Add(word);

                    totalCharacters += word.Length + 1;
                    if (totalCharacters > MaxLength)
                        break;
                }

                var summary = String.Join(" ", summaryWords) + "...";

            }

        }

       
    }
}
