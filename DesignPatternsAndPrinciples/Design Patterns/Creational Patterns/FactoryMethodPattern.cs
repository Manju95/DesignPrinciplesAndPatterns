using System;
namespace DotnetTraining.DesignPatterns.CreationalPatterns.FactoryMethod
{
	//Creates an instance of derived classes
	public class FactoryMethodPattern
	{
		private readonly Creator[] _creators = new Creator[2];
		public FactoryMethodPattern()
		{
			_creators[0] = new CCreatorA();
			_creators[1] = new CCreatorB();
		}

		public void GetProduct()
		{
			foreach (var creator in _creators)
			{
				Product p = creator.ProductFactory();
				Console.WriteLine($"Created {p.GetType().Name}");
			}
		}
	}

	public abstract class Product
	{

	}

	public class CProductA : Product
	{

	}

	public class CProductB : Product
	{

	}

	public abstract class Creator
	{
		public abstract Product ProductFactory();
	}

    public class CCreatorA : Creator
    {
        public override Product ProductFactory()
        {
			return new CProductA();
        }
    }

    public class CCreatorB : Creator
    {
        public override Product ProductFactory()
        {
            return new CProductB();
        }
    }
}

