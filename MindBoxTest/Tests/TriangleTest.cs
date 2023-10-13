using MindBoxTest.Figures;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxTest.Tests
{
    internal class TriangleTest
    {
        [SetUp]
        public void Setup() { }

        [Test]
        public void WrongEdgeLengthTest()
        {
            Assert.Catch<ArgumentException>(() => new Triangle(3d, 4d, 0d));
        }

        [Test]
        public void IsTriangleTest()
        {
            Triangle triangle = new Triangle(1d, 2d, 3d);
            Assert.That(triangle.IsTriangle, Is.EqualTo(false));
        }

        [Test]
        public void ISRightTriangle()
        {
            Triangle triangle = new Triangle(3d, 5d, 4d);
            Assert.That(triangle.IsRightTriangle, Is.EqualTo(true));
        }

        [Test]
        public void GetAreaTest()
        {
            Triangle triangle = new Triangle(3d, 4d, 5d);
            var area = triangle.GetArea();
            Assert.AreEqual(6, area);
        }
    }
}
