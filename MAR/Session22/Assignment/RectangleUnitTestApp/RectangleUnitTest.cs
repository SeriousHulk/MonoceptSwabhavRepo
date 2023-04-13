using Microsoft.VisualStudio.TestTools.UnitTesting;
using RectangleEnumApp.Model;

namespace RectangleUnitTestApp
{
    [TestClass]
    public class RectangleUnitTest
    {
        [TestMethod]
        public void ShouldCreateThe_3_ParameterConstaructorObject()
        {
            BorderOption expectedBorder = BorderOption.SINGLE;
            Rectangle rectangle = new Rectangle(12, 23, ColorOption.BLUE);
            Assert.AreEqual(expectedBorder, rectangle.Border);
        }
        [TestMethod]
        public void ShouldCreateThe_4_ParameterConstaructorObject()
        {
            BorderOption expectedBorder = BorderOption.DOTTED;
            Rectangle rectangle = new Rectangle(12, 5, ColorOption.BLUE, BorderOption.DOTTED);
            Assert.AreEqual(expectedBorder, rectangle.Border);
        }
        [TestMethod]
        public void ShouldCreateRectangleObjectWithOnlyValuesThatArePassedIntoConstructor()
        {
            Rectangle rectangle = new Rectangle(7, 91, ColorOption.BLUE, BorderOption.DOTTED);
            int expectedRectangleHeight = 91;
            int expectedRectangleWidth = 7;
            ColorOption expectedColor = ColorOption.BLUE;
            BorderOption expectedBorder = BorderOption.DOTTED;
            Assert.AreEqual(expectedBorder, rectangle.Border);
            Assert.AreEqual(expectedColor, rectangle.Color);
            Assert.AreEqual(expectedRectangleWidth, rectangle.Width);
            Assert.AreEqual(expectedRectangleHeight, rectangle.Height);
        }
        [TestMethod]
        public void ShouldCalculateAreaOfRectangleWithValidHeightAndWidth()
        {
            Rectangle rectangle = new Rectangle(7, 91, ColorOption.BLUE, BorderOption.DOTTED);
            int expectedArea = 637;
            Assert.AreEqual(expectedArea, rectangle.CalculateArea());
        }
        [TestMethod]
        public void ShouldCalculateAreaOfRectangleEvenWithHeightAndWidthNotInRange()
        {
            Rectangle rectangle = new Rectangle(-7, 111, ColorOption.RED, BorderOption.DOTTED);
            int expectedArea = 100;
            Assert.AreEqual(expectedArea, rectangle.CalculateArea());
        }
        [TestMethod]
        public void ShouldCalculateAreaOfRectangleEvenWithHeightAndWidthAre_0()
        {
            Rectangle rectangle = new Rectangle(0, 0, ColorOption.BLUE, BorderOption.DOTTED);
            int expectedArea = 1;
            Assert.AreEqual(expectedArea, rectangle.CalculateArea());
        }
        [TestMethod]
        public void ShouldAcceptHeightAndWidthFromProperties()
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Width = 10;
            rectangle.Height = 11;
            int expectedRectangleHeight = 11;
            int expectedRectangleWidth = 10;
            Assert.AreEqual(expectedRectangleHeight, rectangle.Width);
            Assert.AreEqual(expectedRectangleWidth, rectangle.Width);
        }
        [TestMethod]
        public void ShouldAcceptColorOptionAndBorderOptionFromProperties()
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Color = ColorOption.BLUE;
            rectangle.Border = BorderOption.DOTTED;
            ColorOption expectedColor = ColorOption.BLUE;
            BorderOption expectedBorder = BorderOption.DOTTED;
            Assert.AreEqual(expectedColor, rectangle.Color);
            Assert.AreEqual(expectedBorder, rectangle.Border);
        }
        [TestMethod]
        public void ShouldValidateSidesIfPassedValuesBeyondRange()
        {
            Rectangle rectangle = new Rectangle(-7, 111, ColorOption.RED, BorderOption.DOTTED);
            int expectedRectangleHeight = 100;
            int expectedRectangleWidth = 1;
            Assert.AreEqual(expectedRectangleWidth, rectangle.Width);
            Assert.AreEqual(expectedRectangleHeight, rectangle.Height);
        }
    }
}