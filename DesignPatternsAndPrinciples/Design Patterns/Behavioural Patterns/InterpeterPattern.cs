using System;
namespace DesignPatternsAndPrinciples.DesignPatterns.BehaviouralPatterns
{
	public class InterpeterPattern
	{
		public void Run()
        {
            Context context = new Context();
            List<AbstractExpression> list = new List<AbstractExpression>();
            list.Add(new TerminalExpression());
            list.Add(new NonTerminalExpression());
            list.Add(new TerminalExpression());
            list.Add(new TerminalExpression());
            list.Add(new NonTerminalExpression());

            foreach (AbstractExpression exp in list)
            {
                exp.Interprete(context);
            }
        }
	}

	public class Context
	{

	}

	public abstract class AbstractExpression
	{
		public abstract void Interprete(Context context);
	}

    public class TerminalExpression : AbstractExpression
    {
        public override void Interprete(Context context)
        {
			Console.WriteLine("Terminal.Interprete() invoked");
        }
    }

    public class NonTerminalExpression : AbstractExpression
    {
        public override void Interprete(Context context)
        {
            Console.WriteLine("NonTerminal.Interprete() invoked");
        }
    }
}

