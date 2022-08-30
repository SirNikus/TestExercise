using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorLibrary.Tests
{
	[TestClass()]
	public class CalculateTests
	{
		[TestMethod()]
		public void TriangleTest()
		{
			double arg1 = 3;
			double arg2 = 4;
			double arg3 = 5;

			Triangle triangle = new Triangle(arg1, arg2, arg3);

			double expected = 6;
			double result = triangle.GetSquare();

			Assert.AreEqual(expected, result);
		}

		[TestMethod]
		[ExpectedException(typeof(Exception),
			"Треугольник не существует")]
		public void TriangleNotExistTest()
		{
			double arg1 = 3;
			double arg2 = 4;
			double arg3 = 0;
			Triangle triangle = new Triangle(arg1, arg2, arg3);

			triangle.GetSquare();
		}

		[TestMethod()]
		public void IsTriangeRectangularTest()
		{
			double arg1 = 3;
			double arg2 = 4;
			double arg3 = 5;
			Triangle triangle = new Triangle(arg1, arg2, arg3);

			var result = triangle.IsTriangeRectangular();
			var expected = true;

			Assert.AreEqual(expected, result);
		}
	}


}