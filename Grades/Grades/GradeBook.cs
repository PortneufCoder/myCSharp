using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades  // this is now a class thats part of the project
                    // classes are blueprints for creating objs
{
     public class GradeBook
    {

        public GradeBook() // ctor tab twice creates a new constructor
        {
            _name = "Sans nom";
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
            stats.AverageGrade = sum / grades.Count; // divide the sum of all grades by the number of grades
            return stats;
        }

        public void WriteGrades(TextWriter destination)
        {
            for (int i = grades.Count; i > 0; i--) // we see the grades in reverse order, starting at grades.count(3 : index of 2), then decrement i each time
            {
                destination.WriteLine(grades[i-1]);
            }
        }

        public void AddGrade(float grade) // new class for the project
        {
            grades.Add(grade);

        }

        public string Name // this changes this method to a property. This is an auto-implemented property
        {
            get
            {
                return _name;
            }
            set
            {
                if ( !String.IsNullOrEmpty(value) ) //this code prevents a user from entering an empty value.
                {
                    if ( _name != value )
                    {
                        NameChanged(_name, value);
                    };

                    _name = value;
                }


            } 
        } // public member capitalized. This is a field that can be used elsewhere, like book.Name

        public NameChangedDelegate NameChanged;

        private string _name;
        private List<float> grades;  // this list will hold 0 or more floating point numbers
    }
}
 // public means the code can be accessed outside the class and used lesewhere in the program
 // private means the method(code) of the class can only be used where its delcared.