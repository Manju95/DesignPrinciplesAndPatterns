using System;
using DotnetTraining.DesignPrinciples.SOLID.Models;

namespace DotnetTraining.SOLID
{
	public class OCPExample
	{
		public void RunOCP()
		{
			Circle cir1 = new Circle() { Radius = 10 };
			Circle cir2 = new Circle() { Radius = 12 };

			Rectangle rect1 = new Rectangle() { Height = 5, Width = 3 };
			Rectangle rect2 = new Rectangle() { Height = 3, Width = 8 };

			Shape[] shapes = new Shape[] { cir1, cir2, rect1, rect2 };
			AreaCalculator calc = new AreaCalculator();
			var shapesArea = calc.CalculateTotalArea(shapes);
			Console.WriteLine($"Total area of all shapes : {shapesArea}");
		}
	}

	public class AreaCalculator
	{
		public double TotalArea { get; set; }
		public double CalculateTotalArea(Shape[] shapes)
		{
			foreach (var item in shapes)
			{
                TotalArea += item.CalulateArea();
			}

			return TotalArea;
		}
	}

	public class Circle : Shape
	{
		public double Radius { get; set; }

        public override double CalulateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

	public class Rectangle : Shape
	{
		public double Height { get; set; }
		public double Width { get; set; }

        public override double CalulateArea()
        {
            return Height * Width;
        }
    }
}

