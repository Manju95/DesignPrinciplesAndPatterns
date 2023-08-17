using System;
using DotnetTraining.DesignPatterns.CreationalPatterns.FactoryMethod;
using FactoryMethodProduct = DotnetTraining.DesignPatterns.CreationalPatterns.FactoryMethod.Product;

namespace DotnetTraining.DesignPatterns.CreationalPatterns
{
	public class CreationalPatternsConsumer
	{
		// Abstract Factory Pattern
		public void RunAbstractFactory()
		{
			AbstractFactory factory = new ConcreteFactory1();
			AbstractFactoryExample af = new AbstractFactoryExample(factory);
			af.Run();

			AbstractFactory factory1 = new ConcreteFactory2();
			AbstractFactoryExample af2 = new AbstractFactoryExample(factory1);
			af2.Run();

		}

		// Builder Pattern
		public void RunBuilderPattern()
		{
            Builder builder1 = new CBuilder1();
            BuilderPattern bp = new BuilderPattern(builder1);
			bp.BuildParts();
			bp.GetObject();

			Builder builder2 = new CBuilder2();
            BuilderPattern bp2 = new BuilderPattern(builder2);
            bp2.BuildParts();
            bp2.GetObject();
        }

		// Factory Method
		public void RunFactoryMethod()
		{
			FactoryMethodPattern fmp = new FactoryMethodPattern();
			fmp.GetProduct();
		}

	}
}

