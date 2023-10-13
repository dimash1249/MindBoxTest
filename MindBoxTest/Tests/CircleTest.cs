using MindBoxTest.Figures;

namespace MindBoxTest.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ZeroLessRadiusTest()
        {
            Assert.Catch<ArgumentException>(() => new Circle(-1d));
        }

        [Test]
        public void GetAreaTest()
        {
            Circle circle = new Circle(1d);
            var area = circle.GetArea();
            Assert.That(area, Is.EqualTo(Math.PI));
        }
    }
}