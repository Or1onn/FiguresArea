using FiguresArea.Factories;
using FiguresArea.Interfaces;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace FiguresArea.Tests;


[TestFixture]
public class ShapeTests
{
    [Test]
    public void CircleAreaTest()
    {
        IShape circle = ShapeFactory.CreateCircle(5);
        ClassicAssert.AreEqual(Math.PI * 25, circle.GetArea(), 1e-10);
    }

    [Test]
    public void TriangleAreaTest()
    {
        IShape triangle = ShapeFactory.CreateTriangle(3, 4, 5);
        ClassicAssert.AreEqual(6, triangle.GetArea(), 1e-10);
    }

    [Test]
    public void RightAngledTriangleTest()
    {
        Triangle triangle = new Triangle(3, 4, 5);
        ClassicAssert.IsTrue(triangle.IsRightAngled());
    }

    [Test]
    public void NotRightAngledTriangleTest()
    {
        Triangle triangle = new Triangle(3, 4, 6);
        ClassicAssert.IsFalse(triangle.IsRightAngled());
    }
}