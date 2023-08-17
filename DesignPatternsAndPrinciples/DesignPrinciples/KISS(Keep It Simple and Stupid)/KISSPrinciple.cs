using System;
namespace DotnetTraining.DesignPrinciples
{
	public class KISSPrinciple
	{
		public string GetMonthName(int n)
        {
			switch (n)
			{
				case 1: return "January";
				case 2: return "Febuary";
				case 3: return "March";
				case 4: return "April";
				default: return "Invalid month numner";
			}
		}
	}
}

