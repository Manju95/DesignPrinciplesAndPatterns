using System;
namespace DotnetTraining.DesignPatterns.CreationalPatterns
{
    public class AbstractFactoryExample
    {
        private readonly AbstractProductA abstractProductA;
        private readonly AbstractProductB abstractProductB;

        public AbstractFactoryExample(AbstractFactory factory)
        {
            this.abstractProductA = factory.CreateProductA();
            this.abstractProductB = factory.CreateProductB();
        }

        public void Run()
        {
            abstractProductB.Interact(abstractProductA);
        }
    }

	//Creates an instance of several families of classes
	public abstract class AbstractFactory
	{
		public abstract AbstractProductA CreateProductA();

		public abstract AbstractProductB CreateProductB();
	}

    public abstract class AbstractProductA
    {
    }

    public abstract class AbstractProductB
    {
        public abstract void Interact(AbstractProductA a);
    }

    class ProductA1 : AbstractProductA
    {

    }

    class ProductB1 : AbstractProductB
    {
        public override void Interact(AbstractProductA a)
        {
            Console.WriteLine($"{this.GetType().Name} interacts with {a.GetType().Name}");
        }
    }

    class ProductA2 : AbstractProductA
    {

    }

    class ProductB2 : AbstractProductB
    {
        public override void Interact(AbstractProductA a)
        {
            Console.WriteLine($"{this.GetType().Name} interacts with {a.GetType().Name}");
        }
    }

    class ConcreteFactory1 : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ProductA1();
        }

        public override AbstractProductB CreateProductB()
        {
            return new ProductB1();
        }
    }

    class ConcreteFactory2 : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ProductA2();
        }

        public override AbstractProductB CreateProductB()
        {
            return new ProductB2();
        }
    }
}

