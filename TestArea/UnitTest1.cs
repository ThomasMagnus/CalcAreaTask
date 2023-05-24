using ClassLibrary1;

namespace TestArea
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCircle()
        {
            Circle circle = new Circle(10);
            double circleResult = circle.CalculateSquare();

            Assert.AreEqual(314.16, circleResult);
        }

        [TestMethod]
        public void TestRectangle()
        {
            Rectangle rectangle = new Rectangle(3, 4, 5);
            double resultRectangle = rectangle.CalculateSquare();

            bool isRectangular = rectangle.IsRectangular();

            Assert.AreEqual(6, resultRectangle);
            Assert.IsTrue(isRectangular);
        }
    }
}