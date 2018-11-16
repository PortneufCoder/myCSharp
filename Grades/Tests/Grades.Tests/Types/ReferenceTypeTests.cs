using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.Tests.Types // Testing referencing of types e.g reassigning vars
{
    [TestClass]
    public class TypeTests  
    {

        [TestMethod]
        public void UsingArrays()
        {
            float[] grades;
            grades = new float[3];

            AddGrades(grades);

            Assert.AreEqual(89.1f, grades[1]); // passes since an array is a reference type. test qould failt if we created a new array in the private method.
        }

        private void AddGrades(float[] grades)
        {
            
            grades[1] = 89.1f;
        }

        [TestMethod]
        public void ValueTypesPassByValue()
        {
            int x = 46;
            IncrementNumber(x);

            Assert.AreEqual(46, x); // this test passes because we do not see the code inside the prvate method to increment the integer.
        }

        private void IncrementNumber(int number)
        {
            number += 1;
        }


        [TestMethod]
        public void ReferenceTypesPassByValue()
        {
            GradeBook book1 = new GradeBook();
            GradeBook book2 = book1;

            GiveBookAName(book2);
            Assert.AreEqual("A GradeBook", book1.Name); // this test passes becasue when I invoke GiveBookAName , the value of book2 is copied into parameter book.

        }

        private void GiveBookAName(GradeBook book)
        {
            book.Name = "A GradeBook";
        }


        [TestMethod]
        public void StringComparisons()
        {
            string name1 = "Victor";
            string name2 = "victor";

            bool result = string.Equals(name1, name2, StringComparison.InvariantCultureIgnoreCase);
            Assert.IsTrue(result); // pass
        }

        [TestMethod]
        public void IntVariablesHoldAValue()
        {


            int x1 = 100;
            int x2 = x1;

            x1 = 4;
            //Assert.AreEqual(x1, x2); // fails x2 = 100;
            Assert.AreNotEqual(x1, x2);
        }


        [TestMethod]
        public void VariablesHoldReference()
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;

            g1.Name = "Victor's grade book";
            Assert.AreEqual(g1.Name, g2.Name);
        }

        [TestMethod]
        public void ValidateType()
        {
            int total = 5 * 5 + 5;

            string total2 = "30";

            Assert.AreNotSame(total, total2); // passes since int != string


        }
    }
}
