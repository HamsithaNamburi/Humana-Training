using NUnit.Framework;
using Package;

namespace Test_Package
{
    [TestFixture]
    public class Tests
    {
        private Calculator _calculator;
        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        [Test]
        public void Addtion()
        {
           int  result = _calculator.Addition(4, 6);
            Assert.AreEqual(result, 10);
        }
        [Test]
        public void Multiplication()
        {
            int result = _calculator.Multiplication(5,9);
            Assert.AreEqual(result, 45);
        }
        [Test]
        public void Substraction()
        {
            int result = _calculator.Substraction(8,2);
            Assert.AreEqual(result, 6);
        }
        [Test]
        public void Division()
        {
            int result = _calculator.Division(8,4);
            Assert.AreEqual(result, 2);
        }
    }
}