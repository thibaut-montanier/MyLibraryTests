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

        [TestCase(1,1,1)]
        [TestCase(5,25,5)]
        [TestCase(5.5,11,2)]
        
        public void DiviseTest(decimal expected, decimal numerator, decimal divisor) {
            decimal result = mathscls.Divise(numerator, divisor);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void DiviseBy0Test() {
            try {
                decimal result = mathscls.Divise(5, 0);
                Assert.IsTrue(false);
            } catch (DivideByZeroException zeroex) {
               Assert.IsTrue(true);
            } 
        }

        [Test]
        public void DiviseBy3Test() {
            decimal result = mathscls.Divise(1, 3);
            Assert.That(result, Is.EqualTo(0.333).Within(0.01));
        }


    }
}
