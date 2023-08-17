using System;
namespace DotnetTraining.DesignPatterns.CreationalPatterns
{
	//Separates object construction from its representation
	public class BuilderPattern
	{
        private readonly Builder _builder;
        public BuilderPattern(Builder builder)
        {
            _builder = builder;
            
        }

        public void BuildParts()
        {
            _builder.BuildPartA();
            _builder.BuildPartB();
        }

        public void GetObject()
        {
            var obj = _builder.GetResult();
            obj.Show();
        }
    }

    public class Product
    {
        private List<string> parts = new List<string>();

        public void Add(string part)
        {
            parts.Add(part);
        }

        public void Show()
        {
            Console.WriteLine("Product parts...");
            foreach (var part in parts)
            {
                Console.WriteLine($"\t{part}");
            }
        }
    }

    public abstract class Builder
    {
        public abstract void BuildPartA();
        public abstract void BuildPartB();
        public abstract Product GetResult();
    }

    public class CBuilder1 : Builder
    {
        private Product product = new Product();

        public override void BuildPartA()
        {
            product.Add("Part A");
        }

        public override void BuildPartB()
        {
            product.Add("Part B");
        }

        public override Product GetResult()
        {
            return product;
        }
    }

    public class CBuilder2 : Builder
    {
        private Product product = new Product();

        public override void BuildPartA()
        {
            product.Add("Part X");
        }

        public override void BuildPartB()
        {
            product.Add("Part Y");
        }

        public override Product GetResult()
        {
            return product;
        }
    }
}

