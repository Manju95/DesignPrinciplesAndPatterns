using System;
namespace DesignPatternsAndPrinciples.DesignPatterns.StructuralPatterns
{
	public class ProxyExample
	{
		
	}

	public abstract class Subject
	{
		public abstract void Request();
	}

    public class RealSubject : Subject
    {
        public override void Request()
        {
			Console.WriteLine("ReactSubject.Request() Invoked");
        }
    }

    public class Proxy : Subject
    {
        private RealSubject realSubject;

        public override void Request()
        {
            if(realSubject == null)
            {
                realSubject = new RealSubject();
            }
            realSubject.Request();
        }
    }
}