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
        [Test]
        public void Add3p4Test() {
            int result = mathscls.Add(3, 4);
            Assert.AreEqual(7, result);

        }
    }
}
