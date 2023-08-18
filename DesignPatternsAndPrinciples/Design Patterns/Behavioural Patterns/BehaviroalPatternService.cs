using System;
namespace DesignPatternsAndPrinciples.DesignPatterns.BehaviouralPatterns
{
	public class BehaviroalPatternService
	{
		// ChainOfResponsiblity
		public void RunChainOfResponsiblity()
		{
            ChainOfResponsiblity cor = new ChainOfResponsiblity();
			cor.Run();
        }

		// Command Pattern
		public void RunCommandPattern()
		{
			CommandPattern cp = new CommandPattern();
			cp.Run();
		}

		// Interpreter Pattern
		public void RunInterpreter()
		{
			InterpeterPattern ip = new InterpeterPattern();
			ip.Run();
		}

		// Iterator Pattern
		public void RunIterator()
		{
			IteratorPattern ipr = new IteratorPattern();
			ipr.Run();
		}

		// Mediator Pattern
		public void RunMediator()
		{
			MediatorPattern mp = new MediatorPattern();
			mp.Run();
		}
		
	}
}

