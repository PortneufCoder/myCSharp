using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.Tests.Types // Testing referencing of types e.g reassigning vars
{
    [TestClass]
    public class ReferenceTypeTests
    {
        [TestMethod]
        public void VariablesHoldReference()
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;

            g1.Name = "Victor's grade book";
            Assert.AreEqual(g1.Name, g2.Name);
        }

        [TestMethod]
        public void ConditionalLogic()
        {
            int total = 5 * 5 + 5;

            string total2 = "30";

            Assert.AreNotSame(total, total2); // passes since int != string


        }
    }
}
