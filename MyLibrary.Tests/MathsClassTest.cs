using MyLibrary;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibrary.Tests {
    class MathsClassTest {
        private MathsClass mathscls;

        [SetUp]
        public void Setup() {
            this.mathscls = new MathsClass();
        }

        [TestCase(7,4,3)]
        [TestCase(0,0,0)]
        [TestCase(-2,0,-2)]
        [TestCase(-1,4,-5)]
        public void AddTest(int expected, int val1, int val2) {
            int result = mathscls.Add(val1, val2);
            Assert.AreEqual(expected, result);
        }

       
    }
}
