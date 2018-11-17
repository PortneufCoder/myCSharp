using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            
           
            //SpeechSynthesizer synth = new SpeechSynthesizer(); // added an assembly reference for speech synthesizing
            //synth.Speak("Yo! This is a grade book program");

            GradeBook book = new GradeBook(); // instantiating a new GradeBook object
            book.Name = "Victor's Grade Book!";
           
            book.AddGrade(90);
            book.AddGrade(89.5f); // the 'f specifies to the compiler that this is a float'
            book.AddGrade(75);


            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine(book.Name);
            WriteResult("Average", stats.AverageGrade);
            WriteResult("Highest", (int)stats.HighestGrade); // type casting... we tell compiler to convert this value to an int
            WriteResult("Lowest", stats.LowestGrade);

        }

        static void WriteResult(string description, int result) // helper method. This allows me to output better data from my class above
        {
            Console.WriteLine(description + ": " + result);
        }

        static void WriteResult(string description, float result) // helper method
        {
            Console.WriteLine("{0}: {1}", description, result); // bit like template-literals in js
        }
    }
}
