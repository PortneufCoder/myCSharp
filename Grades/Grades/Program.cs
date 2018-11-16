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
            
           
            SpeechSynthesizer synth = new SpeechSynthesizer(); // added an assembly reference for speech synthesizing
            synth.Speak("Yo! This is a grade book program");

            GradeBook book = new GradeBook(); // instantiating a new GradeBook object
            book.AddGrade(90);
            book.AddGrade(89.5f); // the 'f specifies to the compiler that this is a float'
            book.AddGrade(75);


            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine(stats.AverageGrade);
            Console.WriteLine(stats.HighestGrade);
            Console.WriteLine(stats.LowestGrade);
            




        }
    }
}
