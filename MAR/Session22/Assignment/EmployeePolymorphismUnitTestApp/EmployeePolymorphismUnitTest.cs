using EmployeePolymorphismUnitTestApp.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EmployeePolymorphismUnitTestApp
{
    [TestClass]
    public class EmployeePolymorphismUnitTest
    {
        //1.
        [TestMethod]
        public void ShouldCreateManagerEmployeeWithAtributesPassedIntoConstructor()
        {
            Manager manager = new Manager("Michael", 2322, 1200);
            string expectedName = "Michael";
            int expectedId = 2322;
            double expectedSalary = 1200;
            Assert.AreEqual(expectedName, manager.Name);
            Assert.AreEqual(expectedId, manager.Id);
            Assert.AreEqual(expectedSalary, manager.BasicSalary);
        }
        //2.
        [TestMethod]
        public void ShouldCreateDeveloperEmployeeWithAtributesPassedIntoConstructor()
        {
            Developer developer = new Developer("Jim", 2010, 900);
            string expectedName = "Jim";
            int expectedId = 2010;
            double expectedSalary = 900;
            Assert.AreEqual(expectedName, developer.Name);
            Assert.AreEqual(expectedId, developer.Id);
            Assert.AreEqual(expectedSalary, developer.BasicSalary);
        }
        //3.
        [TestMethod]
        public void ShouldCreateQualityAnalystEmployeeWithAtributesPassedIntoConstructor()
        {
            QualityAnalyst qualityAnalyst = new QualityAnalyst("Creed", 1919, 700);
            string expectedName = "Creed";
            int expectedId = 1919;
            double expectedSalary = 700;
            Assert.AreEqual(expectedName, qualityAnalyst.Name);
            Assert.AreEqual(expectedId, qualityAnalyst.Id);
            Assert.AreEqual(expectedSalary, qualityAnalyst.BasicSalary);
        }
        //4.
        [TestMethod]
        public void ShouldReturnNameOfTheEmployeeIfNamePropertyIsCalled()
        {
            Manager manager = new Manager("Michael", 2322, 1200);
            Developer developer = new Developer("Jim", 2010, 900);
            QualityAnalyst qualityAnalyst = new QualityAnalyst("Creed", 1919, 700);
            Assert.AreEqual(developer.Name, "Jim");
            Assert.AreEqual(manager.Name, "Michael");
            Assert.AreEqual(qualityAnalyst.Name, "Creed");
        }
        //5.
        [TestMethod]
        public void ShouldReturnIdOfTheEmployeeIfIdPropertyIsCalled()
        {
            Manager manager = new Manager("Michael", 2322, 1200);
            Developer developer = new Developer("Jim", 2010, 900);
            QualityAnalyst qualityAnalyst = new QualityAnalyst("Creed", 1919, 700);
            Assert.AreEqual(manager.Id, 2322);
            Assert.AreEqual(developer.Id, 2010);
            Assert.AreEqual(qualityAnalyst.Id, 1919);
        }
        //6.
        [TestMethod]
        public void ShouldReturnSalaryOfTheEmployeeIfSalaryPropertyIsCalled()
        {
            Manager manager = new Manager("Michael", 2322, 1200);
            Developer developer = new Developer("Jim", 2010, 900);
            QualityAnalyst qualityAnalyst = new QualityAnalyst("Creed", 1919, 700);
            Assert.AreEqual(manager.BasicSalary, 1200);
            Assert.AreEqual(developer.BasicSalary, 900);
            Assert.AreEqual(qualityAnalyst.BasicSalary, 700);
        }
        //7.
        [TestMethod]
        public void ShouldCalculateAndReturnCorrectAnnualSalary()
        {
            Manager manager = new Manager("Michael", 2322, 1200);
            Developer developer = new Developer("Jim", 2010, 900);
            QualityAnalyst qualityAnalyst = new QualityAnalyst("Creed", 1919, 700);
            double expectedAnnualSalaryOfManager = 37440;
            double expectedAnnualSalaryOfDeveloper = 20520;
            double expectedAnnualSalaryOfQualityAnalyst = 11760;
            Assert.AreEqual(manager.CalculateAnnualSalary(manager.BasicSalary), expectedAnnualSalaryOfManager);
            Assert.AreEqual(developer.CalculateAnnualSalary(developer.BasicSalary), expectedAnnualSalaryOfDeveloper);
            Assert.AreEqual(qualityAnalyst.CalculateAnnualSalary(qualityAnalyst.BasicSalary), expectedAnnualSalaryOfQualityAnalyst);
        }
        //8.
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ShouldThrowExceptionIfBasicSalaryOfManagerIsZero()
        {
            Manager manager = new Manager("Michael", 2322, 0);
        }
        //9.
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ShouldThrowExceptionIfBasicSalaryOfDeveloperIsZero()
        {
            Developer developer = new Developer("Jim", 2010, 0);
        }
        //10.
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ShouldThrowExceptionIfBasicSalaryOfQualityAnalystIsZero()
        {
            QualityAnalyst qualityAnalyst = new QualityAnalyst("Creed", 1919, 0);
        }
        //11.
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ShouldThrowExceptionIfBasicSalaryOfManagerIsNegative()
        {
            Manager manager = new Manager("Michael", 2322, -1);
        }
        //12.
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ShouldThrowExceptionIfBasicSalaryOfDeveloperIsNegative()
        {
            Developer developer = new Developer("Jim", 2010, -2);
        }
        //13.
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ShouldThrowExceptionIfBasicSalaryOfQualityAnalystIsNegative()
        {
            QualityAnalyst qualityAnalyst = new QualityAnalyst("Creed", 1919, -300);
        }
        //14.
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ShouldThrowExceptionIfNegativeBasicSalaryOfManagerIsPassedInCalculateAnnualSalary()
        {
            Manager manager = new Manager("Michael", 2322,123);
            manager.CalculateAnnualSalary(-3453);
        }
        //15.
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ShouldThrowExceptionIfNegativeBasicSalaryOfDeveloperIsPassedInCalculateAnnualSalary()
        {
            Developer developer = new Developer("Jim", 2010, 2324);
            developer.CalculateAnnualSalary(-3434);
        }
        //16.
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ShouldThrowExceptionIfNegativeBasicSalaryOfQualityAnalystIsPassedInCalculateAnnualSalary()
        {
            QualityAnalyst qualityAnalyst = new QualityAnalyst("Creed", 1919, 546);
            qualityAnalyst.CalculateAnnualSalary(-3453);
        }
        //17.
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ShouldThrowExceptionIfBasicSalary_0_OfManagerIsPassedInCalculateAnnualSalary()
        {
            Manager manager = new Manager("Michael", 2322, 123);
            manager.CalculateAnnualSalary(0);
        }
        //18.
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ShouldThrowExceptionIfBasicSalary_0_OfDeveloperIsPassedInCalculateAnnualSalary()
        {
            Developer developer = new Developer("Jim", 2010, 2324);
            developer.CalculateAnnualSalary(0);
        }
        //19.
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ShouldThrowExceptionIfBasicSalary_0_OfQualityAnalystIsPassedInCalculateAnnualSalary()
        {
            QualityAnalyst qualityAnalyst = new QualityAnalyst("Creed", 1919, 546);
            qualityAnalyst.CalculateAnnualSalary(0);
        }
        //20.
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ShouldThrowExceptionIfNegativeBasicSalaryOfManagerIsPassedInPrintSalary()
        {
            Manager manager = new Manager("Michael", 2322, 123);
            manager.PrintSalary(-3453);
        }
        //21.
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ShouldThrowExceptionIfNegativeBasicSalaryOfDeveloperIsPassedInPrintSalary()
        {
            Developer developer = new Developer("Jim", 2010, 2324);
            developer.PrintSalary(-3434);
        }
        //22.
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ShouldThrowExceptionIfNegativeBasicSalaryOfQualityAnalystIsPassedInPrintSalary()
        {
            QualityAnalyst qualityAnalyst = new QualityAnalyst("Creed", 1919, 546);
            qualityAnalyst.PrintSalary(-3453);
        }
        //23.
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ShouldThrowExceptionIfBasicSalary_0_OfManagerIsPassedInPrintSalary()
        {
            Manager manager = new Manager("Michael", 2322, 123);
            manager.PrintSalary(0);
        }
        //24.
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ShouldThrowExceptionIfBasicSalary_0_OfDeveloperIsPassedInPrintSalary()
        {
            Developer developer = new Developer("Jim", 2010, 2324);
            developer.PrintSalary(0);
        }
        //25.
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ShouldThrowExceptionIfBasicSalary_0_OfQualityAnalystIsPassedInPrintSalary()
        {
            QualityAnalyst qualityAnalyst = new QualityAnalyst("Creed", 1919, 546);
            qualityAnalyst.PrintSalary(0);
        }
    }
}