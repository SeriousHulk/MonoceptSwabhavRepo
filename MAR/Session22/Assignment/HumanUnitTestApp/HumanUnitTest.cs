using HumanUnitTestApp.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HumanUnitTestApp
{
    [TestClass]
    public class HumanUnitTest
    {
        //1.Test Constructor
        [TestMethod]
        public void ShouldCreateThe_5_ParameterConstaructorObject()
        {
            Gender expectedGender = Gender.Male;
            Human mahesh = new Human("Mahesh", 23, 45, 162, Gender.Male);
            Assert.AreEqual(expectedGender, mahesh.Gender);
        }
        //2.Test Name Property
        [TestMethod]
        public void ShouldReturnNameOfHumanIfNamePropertyIsCalled()
        {
            Human mahesh = new Human("Mahesh", 23, 45, 162, Gender.Male);
            string expectedName = "Mahesh";
            Assert.AreEqual(mahesh.Name, expectedName);
        }
        //3.Test Age Property
        [TestMethod]
        public void ShouldReturnAgeOfHumanIfAgePropertyIsCalled()
        {
            Human mahesh = new Human("Mahesh", 23, 45, 162, Gender.Male);
            int expectedAge = 23;
            Assert.AreEqual(mahesh.Age, expectedAge);
        }
        //4. Test Weight Property
        [TestMethod]
        public void ShouldReturnWeightOfHumanIfWeightPropertyIsCalled()
        {
            Human mahesh = new Human("Mahesh", 23, 45, 162, Gender.Male);
            float expectedWeight = 45;
            Assert.AreEqual(mahesh.Weight, expectedWeight);
        }
        //5. Test Height Property
        [TestMethod]
        public void ShouldReturnHeightOfHumanIfHeightPropertyIsCalled()
        {
            Human mahesh = new Human("Mahesh", 23, 45, 162, Gender.Male);
            float expectedHeight = 162;
            Assert.AreEqual(mahesh.Height, expectedHeight);
        }
        //6. Test Gender Enum
        [TestMethod]
        public void ShouldReturnGenderOfHumanIfGenderEnumIsCalled()
        {
            Human mahesh = new Human("Mahesh", 23, 45, 162, Gender.Male);
            Gender expectedGender = Gender.Male;
            Assert.AreEqual(expectedGender, mahesh.Gender);
        }
        //7. Test If Height increses by 2% when Eat() is called
        [TestMethod]
        public void ShouldIncreaseHeightOfHumanIfEatMethodIsCalled()
        {
            Human mahesh = new Human("Mahesh", 23, 45, 162, Gender.Male);
            mahesh.Eat();
            float expectedHeight = 165.24f;
            Assert.AreEqual(mahesh.Height, expectedHeight);
        }
        //8. Test If Weight increses by 1% when Eat() is called
        [TestMethod]
        public void ShouldIncreaseWeightOfHumanIfEatMethodIsCalled()
        {
            Human mahesh = new Human("Mahesh", 23, 45, 162, Gender.Male);
            mahesh.Eat();
            float expectedWeight = 45.45f;
            Assert.AreEqual(mahesh.Weight, expectedWeight);
        }
        //9. Test If Weight decrease by 5% when Workout() is called
        [TestMethod]
        public void ShouldDecreaseWeightOfHumanIfWorkoutMethodIsCalled()
        {
            Human mahesh = new Human("Mahesh", 23, 45, 162, Gender.Male);
            mahesh.Workout();
            float expectedWeight = 42.75f;
            Assert.AreEqual(mahesh.Weight, expectedWeight);
        }
        //10. Test If Weight decrease by 5% when Workout() is called
        [TestMethod]
        public void ShouldReturnBmiWhenCalculateBMIMethodIsCalled()
        {
            Human mahesh = new Human("Mahesh", 23, 45, 162, Gender.Male);
            float heightInMeters = mahesh.Height / 100f;
            float bodyMassIndex = mahesh.Weight / (heightInMeters * heightInMeters);
            float expectedBMI = mahesh.CalculateBMI();
            Assert.AreEqual(bodyMassIndex, expectedBMI);
        }
        //11. Test If ValidateAge is throwing exception
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ShouldThrowExceptionIf_0_AgeIsPassedIntoConstructor()
        {
            Human mahesh = new Human("Mahesh", 0, 45, 162, Gender.Male);
        }
        //12. Test If ValidateAge is throwing exception
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ShouldThrowExceptionIfNegativeAgeIsPassedIntoConstructor()
        {
            Human mahesh = new Human("Mahesh", -12, 45, 162, Gender.Male);
        }
        //13. Test If ValidateWeight is throwing exception
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ShouldThrowExceptionIf_0_WeightIsPassedIntoConstructor()
        {
            Human mahesh = new Human("Mahesh", 12, 0, 162, Gender.Male);
        }
        //14. Test If ValidateWeight is throwing exception
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ShouldThrowExceptionIfNegativeWeightIsPassedIntoConstructor()
        {
            Human mahesh = new Human("Mahesh", 12, -45, 162, Gender.Male);
        }
        //15. Test If ValidateHeight is throwing exception
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ShouldThrowExceptionIf_0_HeightIsPassedIntoConstructor()
        {
            Human mahesh = new Human("Mahesh", 12, 120, 0, Gender.Male);
        }
        //16. Test If ValidateHeight is throwing exception
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ShouldThrowExceptionIfNegativeHeightIsPassedIntoConstructor()
        {
            Human mahesh = new Human("Mahesh", 12, 45, -162, Gender.Male);
        }
    }
}