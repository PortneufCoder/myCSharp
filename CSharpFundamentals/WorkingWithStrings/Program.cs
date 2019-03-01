using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Victor Jenkins ";
            Console.WriteLine("Trim: '{0}'", fullName.Trim());
            Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper());

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1); // start after the index of the space btw both words

            var names = fullName.Split(' '); // split returns an array
            Console.WriteLine("FirstName: " + names[0]);
            Console.WriteLine("LastName: " + names[1]);

            if (String.IsNullOrWhiteSpace(null))
                Console.WriteLine("Invalid");

            // convert String to Number
            var str = "35";
            var age = Convert.ToByte(str);

            // Problem: summarizing text

            var sentence = "Such a very very extremely awesomely outstandingly long boring shoot me in the head text!";
            var summary = StringUtility.SummarizeText(sentence);
            Console.WriteLine(summary);

        }


    }
}
