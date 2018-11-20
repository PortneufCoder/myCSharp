using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeStatistics
    {

        public GradeStatistics()
        {
            HighestGrade = 0;
            LowestGrade = float.MaxValue;
        }

        public string Description
        {
            get
            {
                string result;
                switch (LetterGrade)
                {
                    case "A":
                        result = "Amazing!";
                        break; // the use of 'break' allows us to add all the statements within the same block
                    case "B":
                        result = "Goodish";
                        break;
                    case "C":
                        result = "Average";
                        break;
                    case "D":
                        result = "What the heck did your parents pay for?";
                        break;
                    case "F":
                        result = "Crap. FullStop";
                        break;
                    default:
                        result = "Banjaxed! :(";
                        break;
                        
                }
                return result;
            }
        }

        public string LetterGrade
        {
            get
            {
                string result;
                if (AverageGrade >= 90)
                {
                    result = "A";
                }
                else if (AverageGrade >= 80)
                {
                    result = "B";
                }
                else if (AverageGrade >= 70)
                {
                    result = "C";
                }
                else if (AverageGrade >= 60)
                {
                    result = "D";
                }
                else
                {
                    result = "F";
                }

                {
                    return result;
                }
            }
        }
        public float AverageGrade;
        public float HighestGrade;
        public float LowestGrade;
    }
}
