using Grades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.Tests
{
    [TestClass]
    public class GradeBookTests
    {
        [TestMethod]
        public void ComputeHighestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(10);
            book.AddGrade(90);

            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual(90, result.HighestGrade); // this checks that  HighestGrade from my app is producing the right result.
        }

        [TestMethod]
        public void ComputeLowestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(10);
            book.AddGrade(90);

            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual(10, result.LowestGrade); 
        }

        //[TestMethod]
        //public void ComputeAverageGrade()
        //{
        //    GradeBook book = new GradeBook();
        //    book.AddGrade(90);
        //    book.AddGrade(89.5f); // the 'f specifies to the compiler that this is a float'
        //    book.AddGrade(75);

        //    GradeStatistics result = book.ComputeStatistics();
        //    Assert.AreEqual(85.16, result.AverageGrade);
        //}
    }
}
