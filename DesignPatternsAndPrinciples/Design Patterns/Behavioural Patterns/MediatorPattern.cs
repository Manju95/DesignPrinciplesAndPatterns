using System;
namespace DesignPatternsAndPrinciples.DesignPatterns.BehaviouralPatterns
{
	public class MediatorPattern
	{
		public void Run()
		{
			ConcreteMediator mediator = new ConcreteMediator();
			ConcreteColleague1 c1 = new ConcreteColleague1(mediator);
			ConcreteColleague2 c2 = new ConcreteColleague2(mediator);
			mediator.Colleague1 = c1;
			mediator.Colleague2 = c2;

			c1.Send("How are you ?");
			c2.Send("Fine, Thank you");
		}
	}

	public abstract class Mediator
	{
		public abstract void Send(string message, Colleague colleague);
	}

    public class ConcreteMediator : Mediator
    {
		ConcreteColleague1 c1;
        ConcreteColleague2 c2;

		public ConcreteColleague1 Colleague1
		{
			set { c1 = value; }
		}

        public ConcreteColleague2 Colleague2
        {
            set { c2 = value; }
        }

        public override void Send(string message, Colleague colleague)
        {
            if(colleague == c1)
			{
				c2.Notify(message);
			}
			else
			{
				c1.Notify(message);
			}
        }
    }

	public abstract class Colleague
	{
		protected Mediator _mediator;

		public Colleague(Mediator mediator)
		{
			_mediator = mediator;
		}
	}

    public class ConcreteColleague1 : Colleague
    {
        public ConcreteColleague1(Mediator mediator) : base(mediator)
        {
        }

		public void Send(string message)
		{
			_mediator.Send(message,this);
		}

		public void Notify(string message)
		{
			Console.WriteLine($"Collegue1 gets message : {message}");
		}
    }

    public class ConcreteColleague2 : Colleague
    {
        public ConcreteColleague2(Mediator mediator) : base(mediator)
        {
        }

        public void Send(string message)
        {
            _mediator.Send(message, this);
        }

        public void Notify(string message)
        {
            Console.WriteLine($"Collegue2 gets message : {message}");
        }
    }
}

