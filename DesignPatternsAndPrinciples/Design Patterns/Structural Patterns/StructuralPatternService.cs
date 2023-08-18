using System;
namespace DesignPatternsAndPrinciples.DesignPatterns.StructuralPatterns
{
	public class StructuralPatternService
	{
		// Proxy Pattern
		public void RunProxy()
		{
            Proxy proxy = new Proxy();
			proxy.Request();
        }
	}
}

