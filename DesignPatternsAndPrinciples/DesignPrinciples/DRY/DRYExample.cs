using System;
namespace DotnetTraining.DesignPrinciples.DRY
{
	public class DRYExample
	{
		public DRYExample()
		{
			int a = 5, b = 10, x = 10, y = 20;

			int s1 = AddIntegers(a, b);
			int s2 = AddIntegers(x, y);

			Console.WriteLine($"Sum of {a} and {b} is : {s1}");
            Console.WriteLine($"Sum of {x} and {y} is : {s2}");
        }

        private int AddIntegers(int x, int y)
        {
			return x + y;
        }
    }
}

