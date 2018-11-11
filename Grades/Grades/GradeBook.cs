using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades  // this is now a class thats part of the project
                    // classes are blueprints for creating objs
{
    class GradeBook
    {

        public GradeBook() // ctor tab twice creates a new constructor
        {
            grades = new List<float>();
        }

        public GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats = new GradeStatistics();
           

            float sum = 0;
            foreach( float grade in grades)
            {
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                sum += grade;
            }
            stats.AverageGrade = sum / grades.Count;
            return stats;
        }
        public void AddGrade(float grade) // new class for the project
        {
            grades.Add(grade);

        }

        private List<float> grades;  // this list will hold 0 or more floating point numbers
    }
}
 // public means the code can be accessed outside the class and used lesewhere in the program
 // private means the method(code) of the class can only be used where its delcared.