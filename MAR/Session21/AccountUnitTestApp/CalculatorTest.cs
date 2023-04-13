using AccountUnitTestApp.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AccountUnitTestApp
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void ShouldCubeEvenNumber_2_AndProduceResultOf_8()
        {
            int expectedResult = 8;
            Calculator calculator = new Calculator();
            int realResult = calculator.CubeOnlyEvenNumbers(2);
            Assert.IsTrue(expectedResult == realResult);
        }
        [TestMethod]
        public void ShouldNotCubeOdd_3_AndProduceResultOf_Negative_1()
        {
            int expectedResult = -1;
            Calculator calculator = new Calculator();
            int realResult = calculator.CubeOnlyEvenNumbers(3);
            Assert.IsTrue(expectedResult == realResult);
        }
        [TestMethod]
        public void Add_ShouldReturnSameValueIfThatIsPassedInIt()
        {
            int expectedResult = 3;
            Calculator calculator = new Calculator();
            int realResult = calculator.Add(3);
            Assert.IsTrue(expectedResult == realResult);
        }
        [TestMethod]
        public void Add_ShouldReturnSumOfInfiniteParamsIfPassedInIt()
        {
            int expectedResult = 150;
            Calculator calculator = new Calculator();
            int realResult = calculator.Add(10,20,30,40,50);
            Assert.IsTrue(expectedResult == realResult);
        }
        [TestMethod]
        public void Add_ShouldReturnNegativeValueIfThatIsPassedInIt()
        {
            int expectedResult = -30;
            Calculator calculator = new Calculator();
            int realResult = calculator.Add(-10,-20);
            Assert.IsTrue(expectedResult == realResult);
        }
    }
}
