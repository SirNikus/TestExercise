using SquareCalculator;

namespace CalculatorLibrary
{
	public class Circle : IFigure
	{
		private double Radius { get; set; }
		public Circle(double radius)
		{
			Radius = Math.Pow(radius, 2) * Math.PI;
		}

		public double GetSquare()
		{
			return Radius;
		}
	}
}