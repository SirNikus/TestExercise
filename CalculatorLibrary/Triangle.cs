using SquareCalculator;

namespace CalculatorLibrary
{
	public class Triangle : IFigure
	{
		private double A, B, C;
		public Triangle(double a, double b, double c)
		{
			A = a;
			B = b;
			C = c;
		}
		public bool IsTriangleExist()
		{
			if (A + B < C || A + C < B || C + B < A)
			{
				return false;
			}
			else
			{
				return true;
			}
		}

		public double GetSquare()
		{
			if (IsTriangleExist())
			{
				double perimetr;

				perimetr = (A + B + C) / 2;

				return Math.Sqrt(perimetr * (perimetr - A) * (perimetr - B) * (perimetr - C));
			}
			else
			{
				throw new Exception("Треугольник не существует");
			}
		}

		public bool IsTriangeRectangular()
		{
			if (IsTriangleExist())
			{
				List<double> array = new List<double> { A, B, C };
				double max = array.Max();
				array.Remove(max);

				if (Math.Pow(max, 2) == Math.Pow(array[0], 2) + Math.Pow(array[1], 2))
				{
					return true;
				}
				else
				{
					return false;
				}
			}
			else
			{
				throw new Exception("Треугольник не существует");
			}
		}
	}
}
